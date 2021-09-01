// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.
//
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// ------------------------------------------------
//
// This file is automatically generated.
// Please do not edit these files manually.
//
// ------------------------------------------------

using Elastic.Transport;
using System.Collections.Generic;

#nullable restore
namespace Nest.AsyncSearch
{
	public partial class DeleteDescriptor : RequestDescriptorBase<DeleteDescriptor, DeleteRequestParameters, IDeleteRequest>, IDeleteRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.AsyncSearchDelete;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
		///<summary>/_async_search/{id}</summary>
        public DeleteDescriptor(Nest.Id id) : base(r => r.Required("id", id))
		{
		}
	}

	public partial class GetDescriptor : RequestDescriptorBase<GetDescriptor, GetRequestParameters, IGetRequest>, IGetRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.AsyncSearchGet;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		///<summary>/_async_search/{id}</summary>
        public GetDescriptor(Nest.Id id) : base(r => r.Required("id", id))
		{
		}

		public GetDescriptor KeepAlive(Nest.Time? keepAlive) => Qs("keep_alive", keepAlive);
		public GetDescriptor TypedKeys(bool? typedKeys = true) => Qs("typed_keys", typedKeys);
		public GetDescriptor WaitForCompletionTimeout(Nest.Time? waitForCompletionTimeout) => Qs("wait_for_completion_timeout", waitForCompletionTimeout);
	}

	public partial class StatusDescriptor : RequestDescriptorBase<StatusDescriptor, StatusRequestParameters, IStatusRequest>, IStatusRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.AsyncSearchStatus;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		///<summary>/_async_search/status/{id}</summary>
        public StatusDescriptor(Nest.Id id) : base(r => r.Required("id", id))
		{
		}
	}

	public partial class SubmitDescriptor : RequestDescriptorBase<SubmitDescriptor, SubmitRequestParameters, ISubmitRequest>, ISubmitRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.AsyncSearchSubmit;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		///<summary>/_async_search</summary>
        public SubmitDescriptor() : base()
		{
		}

		///<summary>/{index}/_async_search</summary>
        public SubmitDescriptor(Nest.Indices? index) : base(r => r.Optional("index", index))
		{
		}

		Dictionary<string, Nest.Aggregations.AggregationContainer>? ISubmitRequest.Aggs { get; set; }

		bool? ISubmitRequest.AllowNoIndices { get; set; }

		bool? ISubmitRequest.AllowPartialSearchResults { get; set; }

		string? ISubmitRequest.Analyzer { get; set; }

		bool? ISubmitRequest.AnalyzeWildcard { get; set; }

		Nest.Global.Search.FieldCollapse? ISubmitRequest.Collapse { get; set; }

		Nest.DefaultOperator? ISubmitRequest.DefaultOperator { get; set; }

		string? ISubmitRequest.Df { get; set; }

		Nest.Fields? ISubmitRequest.DocvalueFields { get; set; }

		Nest.ExpandWildcards? ISubmitRequest.ExpandWildcards { get; set; }

		bool? ISubmitRequest.Explain { get; set; }

		int? ISubmitRequest.From { get; set; }

		Nest.Global.Search.Highlight? ISubmitRequest.Highlight { get; set; }

		bool? ISubmitRequest.IgnoreThrottled { get; set; }

		bool? ISubmitRequest.IgnoreUnavailable { get; set; }

		IEnumerable<Dictionary<Nest.IndexName, double>>? ISubmitRequest.IndicesBoost { get; set; }

		Nest.Time? ISubmitRequest.KeepAlive { get; set; }

		bool? ISubmitRequest.Lenient { get; set; }

		long? ISubmitRequest.MaxConcurrentShardRequests { get; set; }

		double? ISubmitRequest.MinScore { get; set; }

		Nest.QueryDsl.QueryContainer? ISubmitRequest.PostFilter { get; set; }

		string? ISubmitRequest.Preference { get; set; }

		bool? ISubmitRequest.Profile { get; set; }

		Nest.Global.Search.PointInTimeReference? ISubmitRequest.Pit { get; set; }

		Nest.QueryDsl.QueryContainer? ISubmitRequest.Query { get; set; }

		string? ISubmitRequest.QueryOnQueryString { get; set; }

		bool? ISubmitRequest.RequestCache { get; set; }

		IEnumerable<Nest.Global.Search.Rescore>? ISubmitRequest.Rescore { get; set; }

		Nest.Routing? ISubmitRequest.Routing { get; set; }

		Dictionary<string, Nest.ScriptField>? ISubmitRequest.ScriptFields { get; set; }

		Nest.Global.Search.SortResults? ISubmitRequest.SearchAfter { get; set; }

		Nest.SearchType? ISubmitRequest.SearchType { get; set; }

		bool? ISubmitRequest.SequenceNumberPrimaryTerm { get; set; }

		int? ISubmitRequest.Size { get; set; }

		Nest.Global.Search.Sort? ISubmitRequest.Sort { get; set; }

		Union<bool, Nest.Global.Search.SourceFilter>? ISubmitRequest.Source { get; set; }

		IEnumerable<string>? ISubmitRequest.Stats { get; set; }

		Nest.Fields? ISubmitRequest.StoredFields { get; set; }

		Dictionary<string, Nest.Global.Search.SuggestContainer>? ISubmitRequest.Suggest { get; set; }

		Nest.Field? ISubmitRequest.SuggestField { get; set; }

		Nest.SuggestMode? ISubmitRequest.SuggestMode { get; set; }

		long? ISubmitRequest.SuggestSize { get; set; }

		string? ISubmitRequest.SuggestText { get; set; }

		long? ISubmitRequest.TerminateAfter { get; set; }

		string? ISubmitRequest.Timeout { get; set; }

		bool? ISubmitRequest.TrackScores { get; set; }

		bool? ISubmitRequest.TrackTotalHits { get; set; }

		bool? ISubmitRequest.Version { get; set; }

		IEnumerable<Union<Nest.Field, Nest.DateField>>? ISubmitRequest.Fields { get; set; }

		public SubmitDescriptor BatchedReduceSize(long? batchedReduceSize) => Qs("batched_reduce_size", batchedReduceSize);
		public SubmitDescriptor WaitForCompletionTimeout(Nest.Time? waitForCompletionTimeout) => Qs("wait_for_completion_timeout", waitForCompletionTimeout);
		public SubmitDescriptor KeepOnCompletion(bool? keepOnCompletion = true) => Qs("keep_on_completion", keepOnCompletion);
		public SubmitDescriptor TypedKeys(bool? typedKeys = true) => Qs("typed_keys", typedKeys);
		public SubmitDescriptor Aggs(Dictionary<string, Nest.Aggregations.AggregationContainer>? aggs) => Assign(aggs, (a, v) => a.Aggs = v);
		public SubmitDescriptor AllowNoIndices(bool? allowNoIndices = true) => Assign(allowNoIndices, (a, v) => a.AllowNoIndices = v);
		public SubmitDescriptor AllowPartialSearchResults(bool? allowPartialSearchResults = true) => Assign(allowPartialSearchResults, (a, v) => a.AllowPartialSearchResults = v);
		public SubmitDescriptor Analyzer(string? analyzer) => Assign(analyzer, (a, v) => a.Analyzer = v);
		public SubmitDescriptor AnalyzeWildcard(bool? analyzeWildcard = true) => Assign(analyzeWildcard, (a, v) => a.AnalyzeWildcard = v);
		public SubmitDescriptor Collapse(Nest.Global.Search.FieldCollapse? collapse) => Assign(collapse, (a, v) => a.Collapse = v);
		public SubmitDescriptor DefaultOperator(Nest.DefaultOperator? defaultOperator) => Assign(defaultOperator, (a, v) => a.DefaultOperator = v);
		public SubmitDescriptor Df(string? df) => Assign(df, (a, v) => a.Df = v);
		public SubmitDescriptor DocvalueFields(Nest.Fields? docvalueFields) => Assign(docvalueFields, (a, v) => a.DocvalueFields = v);
		public SubmitDescriptor ExpandWildcards(Nest.ExpandWildcards? expandWildcards) => Assign(expandWildcards, (a, v) => a.ExpandWildcards = v);
		public SubmitDescriptor Explain(bool? explain = true) => Assign(explain, (a, v) => a.Explain = v);
		public SubmitDescriptor From(int? from) => Assign(from, (a, v) => a.From = v);
		public SubmitDescriptor Highlight(Nest.Global.Search.Highlight? highlight) => Assign(highlight, (a, v) => a.Highlight = v);
		public SubmitDescriptor IgnoreThrottled(bool? ignoreThrottled = true) => Assign(ignoreThrottled, (a, v) => a.IgnoreThrottled = v);
		public SubmitDescriptor IgnoreUnavailable(bool? ignoreUnavailable = true) => Assign(ignoreUnavailable, (a, v) => a.IgnoreUnavailable = v);
		public SubmitDescriptor IndicesBoost(IEnumerable<Dictionary<Nest.IndexName, double>>? indicesBoost) => Assign(indicesBoost, (a, v) => a.IndicesBoost = v);
		public SubmitDescriptor KeepAlive(Nest.Time? keepAlive) => Assign(keepAlive, (a, v) => a.KeepAlive = v);
		public SubmitDescriptor Lenient(bool? lenient = true) => Assign(lenient, (a, v) => a.Lenient = v);
		public SubmitDescriptor MaxConcurrentShardRequests(long? maxConcurrentShardRequests) => Assign(maxConcurrentShardRequests, (a, v) => a.MaxConcurrentShardRequests = v);
		public SubmitDescriptor MinScore(double? minScore) => Assign(minScore, (a, v) => a.MinScore = v);
		public SubmitDescriptor PostFilter(Nest.QueryDsl.QueryContainer? postFilter) => Assign(postFilter, (a, v) => a.PostFilter = v);
		public SubmitDescriptor Preference(string? preference) => Assign(preference, (a, v) => a.Preference = v);
		public SubmitDescriptor Profile(bool? profile = true) => Assign(profile, (a, v) => a.Profile = v);
		public SubmitDescriptor Pit(Nest.Global.Search.PointInTimeReference? pit) => Assign(pit, (a, v) => a.Pit = v);
		public SubmitDescriptor Query(Nest.QueryDsl.QueryContainer? query) => Assign(query, (a, v) => a.Query = v);
		public SubmitDescriptor QueryOnQueryString(string? queryOnQueryString) => Assign(queryOnQueryString, (a, v) => a.QueryOnQueryString = v);
		public SubmitDescriptor RequestCache(bool? requestCache = true) => Assign(requestCache, (a, v) => a.RequestCache = v);
		public SubmitDescriptor Rescore(IEnumerable<Nest.Global.Search.Rescore>? rescore) => Assign(rescore, (a, v) => a.Rescore = v);
		public SubmitDescriptor Routing(Nest.Routing? routing) => Assign(routing, (a, v) => a.Routing = v);
		public SubmitDescriptor ScriptFields(Dictionary<string, Nest.ScriptField>? scriptFields) => Assign(scriptFields, (a, v) => a.ScriptFields = v);
		public SubmitDescriptor SearchAfter(Nest.Global.Search.SortResults? searchAfter) => Assign(searchAfter, (a, v) => a.SearchAfter = v);
		public SubmitDescriptor SearchType(Nest.SearchType? searchType) => Assign(searchType, (a, v) => a.SearchType = v);
		public SubmitDescriptor SequenceNumberPrimaryTerm(bool? sequenceNumberPrimaryTerm = true) => Assign(sequenceNumberPrimaryTerm, (a, v) => a.SequenceNumberPrimaryTerm = v);
		public SubmitDescriptor Size(int? size) => Assign(size, (a, v) => a.Size = v);
		public SubmitDescriptor Sort(Nest.Global.Search.Sort? sort) => Assign(sort, (a, v) => a.Sort = v);
		public SubmitDescriptor Source(Union<bool, Nest.Global.Search.SourceFilter>? source) => Assign(source, (a, v) => a.Source = v);
		public SubmitDescriptor Stats(IEnumerable<string>? stats) => Assign(stats, (a, v) => a.Stats = v);
		public SubmitDescriptor StoredFields(Nest.Fields? storedFields) => Assign(storedFields, (a, v) => a.StoredFields = v);
		public SubmitDescriptor Suggest(Dictionary<string, Nest.Global.Search.SuggestContainer>? suggest) => Assign(suggest, (a, v) => a.Suggest = v);
		public SubmitDescriptor SuggestField(Nest.Field? suggestField) => Assign(suggestField, (a, v) => a.SuggestField = v);
		public SubmitDescriptor SuggestMode(Nest.SuggestMode? suggestMode) => Assign(suggestMode, (a, v) => a.SuggestMode = v);
		public SubmitDescriptor SuggestSize(long? suggestSize) => Assign(suggestSize, (a, v) => a.SuggestSize = v);
		public SubmitDescriptor SuggestText(string? suggestText) => Assign(suggestText, (a, v) => a.SuggestText = v);
		public SubmitDescriptor TerminateAfter(long? terminateAfter) => Assign(terminateAfter, (a, v) => a.TerminateAfter = v);
		public SubmitDescriptor Timeout(string? timeout) => Assign(timeout, (a, v) => a.Timeout = v);
		public SubmitDescriptor TrackScores(bool? trackScores = true) => Assign(trackScores, (a, v) => a.TrackScores = v);
		public SubmitDescriptor TrackTotalHits(bool? trackTotalHits = true) => Assign(trackTotalHits, (a, v) => a.TrackTotalHits = v);
		public SubmitDescriptor Version(bool? version = true) => Assign(version, (a, v) => a.Version = v);
		public SubmitDescriptor Fields(IEnumerable<Union<Nest.Field, Nest.DateField>>? fields) => Assign(fields, (a, v) => a.Fields = v);
	}
}