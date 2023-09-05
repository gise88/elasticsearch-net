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

#nullable restore

using Elastic.Clients.Elasticsearch.Fluent;
using Elastic.Clients.Elasticsearch.Serialization;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Aggregations;

internal sealed class VariableWidthHistogramAggregationConverter : JsonConverter<VariableWidthHistogramAggregation>
{
	public override VariableWidthHistogramAggregation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		if (reader.TokenType != JsonTokenType.StartObject)
			throw new JsonException("Unexpected JSON detected.");
		reader.Read();
		var aggName = reader.GetString();
		if (aggName != "variable_width_histogram")
			throw new JsonException("Unexpected JSON detected.");
		var agg = new VariableWidthHistogramAggregation(aggName);
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType == JsonTokenType.PropertyName)
			{
				if (reader.ValueTextEquals("buckets"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<int?>(ref reader, options);
					if (value is not null)
					{
						agg.Buckets = value;
					}

					continue;
				}

				if (reader.ValueTextEquals("field"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Field?>(ref reader, options);
					if (value is not null)
					{
						agg.Field = value;
					}

					continue;
				}

				if (reader.ValueTextEquals("initial_buffer"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<int?>(ref reader, options);
					if (value is not null)
					{
						agg.InitialBuffer = value;
					}

					continue;
				}

				if (reader.ValueTextEquals("shard_size"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<int?>(ref reader, options);
					if (value is not null)
					{
						agg.ShardSize = value;
					}

					continue;
				}
			}
		}

		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType == JsonTokenType.PropertyName)
			{
				if (reader.ValueTextEquals("meta"))
				{
					var value = JsonSerializer.Deserialize<Dictionary<string, object>>(ref reader, options);
					if (value is not null)
					{
						agg.Meta = value;
					}

					continue;
				}
			}
		}

		return agg;
	}

	public override void Write(Utf8JsonWriter writer, VariableWidthHistogramAggregation value, JsonSerializerOptions options)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("variable_width_histogram");
		writer.WriteStartObject();
		if (value.Buckets.HasValue)
		{
			writer.WritePropertyName("buckets");
			writer.WriteNumberValue(value.Buckets.Value);
		}

		if (value.Field is not null)
		{
			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, value.Field, options);
		}

		if (value.InitialBuffer.HasValue)
		{
			writer.WritePropertyName("initial_buffer");
			writer.WriteNumberValue(value.InitialBuffer.Value);
		}

		if (value.ShardSize.HasValue)
		{
			writer.WritePropertyName("shard_size");
			writer.WriteNumberValue(value.ShardSize.Value);
		}

		writer.WriteEndObject();
		if (value.Meta is not null)
		{
			writer.WritePropertyName("meta");
			JsonSerializer.Serialize(writer, value.Meta, options);
		}

		writer.WriteEndObject();
	}
}

[JsonConverter(typeof(VariableWidthHistogramAggregationConverter))]
public sealed partial class VariableWidthHistogramAggregation : SearchAggregation
{
	public VariableWidthHistogramAggregation(string name) => Name = name;

	internal VariableWidthHistogramAggregation()
	{
	}

	/// <summary>
	/// <para>The target number of buckets.</para>
	/// </summary>
	public int? Buckets { get; set; }

	/// <summary>
	/// <para>The name of the field.</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Field? Field { get; set; }

	/// <summary>
	/// <para>Specifies the number of individual documents that will be stored in memory on a shard before the initial bucketing algorithm is run.<br/>Defaults to `min(10 * shard_size, 50000)`.</para>
	/// </summary>
	public int? InitialBuffer { get; set; }
	public IDictionary<string, object>? Meta { get; set; }
	override public string? Name { get; internal set; }

	/// <summary>
	/// <para>The number of buckets that the coordinating node will request from each shard.<br/>Defaults to `buckets * 50`.</para>
	/// </summary>
	public int? ShardSize { get; set; }
}

public sealed partial class VariableWidthHistogramAggregationDescriptor<TDocument> : SerializableDescriptor<VariableWidthHistogramAggregationDescriptor<TDocument>>
{
	internal VariableWidthHistogramAggregationDescriptor(Action<VariableWidthHistogramAggregationDescriptor<TDocument>> configure) => configure.Invoke(this);

	public VariableWidthHistogramAggregationDescriptor() : base()
	{
	}

	private int? BucketsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Field? FieldValue { get; set; }
	private int? InitialBufferValue { get; set; }
	private IDictionary<string, object>? MetaValue { get; set; }
	private int? ShardSizeValue { get; set; }

	/// <summary>
	/// <para>The target number of buckets.</para>
	/// </summary>
	public VariableWidthHistogramAggregationDescriptor<TDocument> Buckets(int? buckets)
	{
		BucketsValue = buckets;
		return Self;
	}

	/// <summary>
	/// <para>The name of the field.</para>
	/// </summary>
	public VariableWidthHistogramAggregationDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field? field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The name of the field.</para>
	/// </summary>
	public VariableWidthHistogramAggregationDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>Specifies the number of individual documents that will be stored in memory on a shard before the initial bucketing algorithm is run.<br/>Defaults to `min(10 * shard_size, 50000)`.</para>
	/// </summary>
	public VariableWidthHistogramAggregationDescriptor<TDocument> InitialBuffer(int? initialBuffer)
	{
		InitialBufferValue = initialBuffer;
		return Self;
	}

	public VariableWidthHistogramAggregationDescriptor<TDocument> Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	/// <summary>
	/// <para>The number of buckets that the coordinating node will request from each shard.<br/>Defaults to `buckets * 50`.</para>
	/// </summary>
	public VariableWidthHistogramAggregationDescriptor<TDocument> ShardSize(int? shardSize)
	{
		ShardSizeValue = shardSize;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("variable_width_histogram");
		writer.WriteStartObject();
		if (BucketsValue.HasValue)
		{
			writer.WritePropertyName("buckets");
			writer.WriteNumberValue(BucketsValue.Value);
		}

		if (FieldValue is not null)
		{
			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, FieldValue, options);
		}

		if (InitialBufferValue.HasValue)
		{
			writer.WritePropertyName("initial_buffer");
			writer.WriteNumberValue(InitialBufferValue.Value);
		}

		if (ShardSizeValue.HasValue)
		{
			writer.WritePropertyName("shard_size");
			writer.WriteNumberValue(ShardSizeValue.Value);
		}

		writer.WriteEndObject();
		if (MetaValue is not null)
		{
			writer.WritePropertyName("meta");
			JsonSerializer.Serialize(writer, MetaValue, options);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class VariableWidthHistogramAggregationDescriptor : SerializableDescriptor<VariableWidthHistogramAggregationDescriptor>
{
	internal VariableWidthHistogramAggregationDescriptor(Action<VariableWidthHistogramAggregationDescriptor> configure) => configure.Invoke(this);

	public VariableWidthHistogramAggregationDescriptor() : base()
	{
	}

	private int? BucketsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Field? FieldValue { get; set; }
	private int? InitialBufferValue { get; set; }
	private IDictionary<string, object>? MetaValue { get; set; }
	private int? ShardSizeValue { get; set; }

	/// <summary>
	/// <para>The target number of buckets.</para>
	/// </summary>
	public VariableWidthHistogramAggregationDescriptor Buckets(int? buckets)
	{
		BucketsValue = buckets;
		return Self;
	}

	/// <summary>
	/// <para>The name of the field.</para>
	/// </summary>
	public VariableWidthHistogramAggregationDescriptor Field(Elastic.Clients.Elasticsearch.Field? field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The name of the field.</para>
	/// </summary>
	public VariableWidthHistogramAggregationDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The name of the field.</para>
	/// </summary>
	public VariableWidthHistogramAggregationDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>Specifies the number of individual documents that will be stored in memory on a shard before the initial bucketing algorithm is run.<br/>Defaults to `min(10 * shard_size, 50000)`.</para>
	/// </summary>
	public VariableWidthHistogramAggregationDescriptor InitialBuffer(int? initialBuffer)
	{
		InitialBufferValue = initialBuffer;
		return Self;
	}

	public VariableWidthHistogramAggregationDescriptor Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	/// <summary>
	/// <para>The number of buckets that the coordinating node will request from each shard.<br/>Defaults to `buckets * 50`.</para>
	/// </summary>
	public VariableWidthHistogramAggregationDescriptor ShardSize(int? shardSize)
	{
		ShardSizeValue = shardSize;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("variable_width_histogram");
		writer.WriteStartObject();
		if (BucketsValue.HasValue)
		{
			writer.WritePropertyName("buckets");
			writer.WriteNumberValue(BucketsValue.Value);
		}

		if (FieldValue is not null)
		{
			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, FieldValue, options);
		}

		if (InitialBufferValue.HasValue)
		{
			writer.WritePropertyName("initial_buffer");
			writer.WriteNumberValue(InitialBufferValue.Value);
		}

		if (ShardSizeValue.HasValue)
		{
			writer.WritePropertyName("shard_size");
			writer.WriteNumberValue(ShardSizeValue.Value);
		}

		writer.WriteEndObject();
		if (MetaValue is not null)
		{
			writer.WritePropertyName("meta");
			JsonSerializer.Serialize(writer, MetaValue, options);
		}

		writer.WriteEndObject();
	}
}