using System.Collections.Generic;
using System.Linq;

namespace Nest
{
	public class AggregationsHelper
	{
		public IDictionary<string, IAggregationItem> Aggregations { get; internal protected set; }

		public AggregationsHelper() { }

		public AggregationsHelper(IDictionary<string, IAggregationItem> aggregations)
		{
			this.Aggregations = aggregations;
		}

		public ValueMetric Min(string key) => this.TryGet<ValueMetric>(key);

		public ValueMetric Max(string key) => this.TryGet<ValueMetric>(key);

		public ValueMetric Sum(string key) => this.TryGet<ValueMetric>(key);

		public ValueMetric Cardinality(string key) => this.TryGet<ValueMetric>(key);

		public ValueMetric Average(string key) => this.TryGet<ValueMetric>(key);

		public ValueMetric ValueCount(string key) => this.TryGet<ValueMetric>(key);

		public ValueMetric AverageBucket(string key) => this.TryGet<ValueMetric>(key);

		public ValueMetric Derivative(string key) => this.TryGet<ValueMetric>(key);

		public ValueMetric SumBucket(string key) => this.TryGet<ValueMetric>(key);

		public ValueMetric MovingAverage(string key) => this.TryGet<ValueMetric>(key);

		public ValueMetric CumulativeSum(string key) => this.TryGet<ValueMetric>(key);

		public ValueMetric BucketScript(string key) => this.TryGet<ValueMetric>(key);

		public KeyedValueMetric MaxBucket(string key) => this.TryGet<KeyedValueMetric>(key);

		public KeyedValueMetric MinBucket(string key) => this.TryGet<KeyedValueMetric>(key);

		public ScriptedValueMetric ScriptedMetric(string key)
		{
			var valueMetric = this.TryGet<ValueMetric>(key);

			return valueMetric != null 
				? new ScriptedValueMetric { _Value = valueMetric.Value, Meta = valueMetric.Meta } 
				: this.TryGet<ScriptedValueMetric>(key);
		}

		public StatsMetric Stats(string key) => this.TryGet<StatsMetric>(key);

		public ExtendedStatsMetric ExtendedStats(string key) => this.TryGet<ExtendedStatsMetric>(key);

		public GeoBoundsMetric GeoBounds(string key) => this.TryGet<GeoBoundsMetric>(key);

		public PercentilesMetric Percentiles(string key) => this.TryGet<PercentilesMetric>(key);

		public PercentilesMetric PercentileRanks(string key) => this.TryGet<PercentilesMetric>(key);

		public TopHitsMetric TopHits(string key) => this.TryGet<TopHitsMetric>(key);

		public FiltersBucket Filters(string key)
		{
			var named = this.TryGet<FiltersBucket>(key);
			if (named != null)
				return named;

			var anonymous = this.TryGet<BucketDto>(key);
			return anonymous != null ? new FiltersBucket(anonymous.Items) { Meta = anonymous.Meta } : null;
		}

		public DocCountBucket Global(string key) => this.TryGet<DocCountBucket>(key);

		public DocCountBucket Filter(string key) => this.TryGet<DocCountBucket>(key);

		public DocCountBucket Missing(string key) => this.TryGet<DocCountBucket>(key);

		public DocCountBucket Nested(string key) => this.TryGet<DocCountBucket>(key);

		public DocCountBucket ReverseNested(string key) => this.TryGet<DocCountBucket>(key);

		public DocCountBucket Children(string key) => this.TryGet<DocCountBucket>(key);

		public DocCountBucket Sampler(string key) => this.TryGet<DocCountBucket>(key);

		public DocCountBucket<SignificantTermItem> SignificantTerms(string key)
		{
			var bucket = this.TryGet<BucketDto>(key);
			return bucket == null
				? null
				: new DocCountBucket<SignificantTermItem>
				{
					DocCount = bucket.DocCount,
					Items = bucket.Items.OfType<SignificantTermItem>().ToList(),
					Meta = bucket.Meta
				};
		}

		public TermsBucket Terms(string key)
		{
			var bucket = this.TryGet<BucketDto>(key);
			return bucket == null
				? null
				: new TermsBucket
				{
					DocCountErrorUpperBound = bucket.DocCountErrorUpperBound,
					SumOtherDocCount = bucket.SumOtherDocCount,
					Items = bucket.Items.OfType<KeyedBucketItem>().ToList(),
					Meta = bucket.Meta
				};
		}

		public Bucket<HistogramItem> Histogram(string key)
		{
			var bucket = this.TryGet<BucketDto>(key);
			return bucket == null
				? null
				: new Bucket<HistogramItem>
				{
					Items = bucket.Items.OfType<HistogramItem>()
						.Concat(bucket.Items.OfType<KeyedBucketItem>()
							.Select(x =>
								new HistogramItem
								{
									Key = long.Parse(x.Key),
									KeyAsString = x.Key,
									DocCount = x.DocCount.GetValueOrDefault(0),
									Aggregations = x.Aggregations
								}
							)
						)
						.ToList(),
					Meta = bucket.Meta
				};
		}

		public Bucket<KeyedBucketItem> GeoHash(string key) => GetBucket<KeyedBucketItem>(key);

		public Bucket<RangeItem> Range(string key) => GetBucket<RangeItem>(key);

		public Bucket<RangeItem> DateRange(string key) => GetBucket<RangeItem>(key);

		public Bucket<RangeItem> IpRange(string key) => GetBucket<RangeItem>(key);

		public Bucket<RangeItem> GeoDistance(string key) => GetBucket<RangeItem>(key);

		public Bucket<DateHistogramItem> DateHistogram(string key) => GetBucket<DateHistogramItem>(key);

		private TAggregation TryGet<TAggregation>(string key)
			where TAggregation : class, IAggregationItem
		{
			IAggregationItem agg;
			return this.Aggregations.TryGetValue(key, out agg) ? agg as TAggregation : null;
		}

		private Bucket<TBucketItem> GetBucket<TBucketItem>(string key)
			where TBucketItem : IBucketItem
		{
			var bucket = this.TryGet<BucketDto>(key);
			if (bucket == null) return null;
			return new Bucket<TBucketItem>
			{
				Items = bucket.Items.OfType<TBucketItem>().ToList(),
				Meta = bucket.Meta
			};
		}
	}
}