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

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.TransformManagement
{
	[JsonConverter(typeof(PivotGroupByContainerConverter))]
	public sealed partial class PivotGroupByContainer
	{
		internal PivotGroupByContainer(string variantName, object variant)
		{
			if (variantName is null)
				throw new ArgumentNullException(nameof(variantName));
			if (variant is null)
				throw new ArgumentNullException(nameof(variant));
			if (string.IsNullOrWhiteSpace(variantName))
				throw new ArgumentException("Variant name must not be empty or whitespace.");
			VariantName = variantName;
			Variant = variant;
		}

		internal object Variant { get; }

		internal string VariantName { get; }

		public static PivotGroupByContainer DateHistogram(Elastic.Clients.Elasticsearch.Aggregations.DateHistogramAggregation dateHistogramAggregation) => new PivotGroupByContainer("date_histogram", dateHistogramAggregation);
		public static PivotGroupByContainer Histogram(Elastic.Clients.Elasticsearch.Aggregations.HistogramAggregation histogramAggregation) => new PivotGroupByContainer("histogram", histogramAggregation);
		public static PivotGroupByContainer Terms(Elastic.Clients.Elasticsearch.Aggregations.TermsAggregation termsAggregation) => new PivotGroupByContainer("terms", termsAggregation);
	}

	internal sealed class PivotGroupByContainerConverter : JsonConverter<PivotGroupByContainer>
	{
		public override PivotGroupByContainer Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType != JsonTokenType.StartObject)
			{
				throw new JsonException("Expected start token.");
			}

			reader.Read();
			if (reader.TokenType != JsonTokenType.PropertyName)
			{
				throw new JsonException("Expected a property name token representing the variant held within this container.");
			}

			var propertyName = reader.GetString();
			reader.Read();
			if (propertyName == "date_histogram")
			{
				var variant = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Aggregations.DateHistogramAggregation?>(ref reader, options);
				reader.Read();
				return new PivotGroupByContainer(propertyName, variant);
			}

			if (propertyName == "histogram")
			{
				var variant = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Aggregations.HistogramAggregation?>(ref reader, options);
				reader.Read();
				return new PivotGroupByContainer(propertyName, variant);
			}

			if (propertyName == "terms")
			{
				var variant = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Aggregations.TermsAggregation?>(ref reader, options);
				reader.Read();
				return new PivotGroupByContainer(propertyName, variant);
			}

			throw new JsonException();
		}

		public override void Write(Utf8JsonWriter writer, PivotGroupByContainer value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();
			writer.WritePropertyName(value.VariantName);
			switch (value.VariantName)
			{
				case "date_histogram":
					JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.Aggregations.DateHistogramAggregation>(writer, (Elastic.Clients.Elasticsearch.Aggregations.DateHistogramAggregation)value.Variant, options);
					break;
				case "histogram":
					JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.Aggregations.HistogramAggregation>(writer, (Elastic.Clients.Elasticsearch.Aggregations.HistogramAggregation)value.Variant, options);
					break;
				case "terms":
					JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.Aggregations.TermsAggregation>(writer, (Elastic.Clients.Elasticsearch.Aggregations.TermsAggregation)value.Variant, options);
					break;
			}

			writer.WriteEndObject();
		}
	}

	public sealed partial class PivotGroupByContainerDescriptor<TDocument> : SerializableDescriptorBase<PivotGroupByContainerDescriptor<TDocument>>
	{
		internal PivotGroupByContainerDescriptor(Action<PivotGroupByContainerDescriptor<TDocument>> configure) => configure.Invoke(this);
		public PivotGroupByContainerDescriptor() : base()
		{
		}

		private bool ContainsVariant { get; set; }

		private string ContainedVariantName { get; set; }

		private object Variant { get; set; }

		private Descriptor Descriptor { get; set; }

		private void Set<T>(Action<T> descriptorAction, string variantName)
			where T : Descriptor
		{
			if (ContainsVariant)
				throw new InvalidOperationException("A variant has already been assigned to the PivotGroupByContainerDescriptor. Only a single PivotGroupByContainer variant can be added to this container type.");
			ContainedVariantName = variantName;
			ContainsVariant = true;
			var descriptor = (T)Activator.CreateInstance(typeof(T), true);
			descriptorAction?.Invoke(descriptor);
			Descriptor = descriptor;
		}

		private void Set(object variant, string variantName)
		{
			if (ContainsVariant)
				throw new Exception("A variant has already been assigned to the PivotGroupByContainerDescriptor. Only a single PivotGroupByContainer variant can be added to this container type.");
			Variant = variant;
			ContainedVariantName = variantName;
			ContainsVariant = true;
		}

		public void DateHistogram(Aggregations.DateHistogramAggregation variant) => Set(variant, "date_histogram");
		public void DateHistogram(Action<Aggregations.DateHistogramAggregationDescriptor<TDocument>> configure) => Set(configure, "date_histogram");
		public void Histogram(Aggregations.HistogramAggregation variant) => Set(variant, "histogram");
		public void Histogram(Action<Aggregations.HistogramAggregationDescriptor<TDocument>> configure) => Set(configure, "histogram");
		public void Terms(Aggregations.TermsAggregation variant) => Set(variant, "terms");
		public void Terms(Action<Aggregations.TermsAggregationDescriptor<TDocument>> configure) => Set(configure, "terms");
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			if (!ContainsVariant)
			{
				writer.WriteNullValue();
				return;
			}

			writer.WriteStartObject();
			writer.WritePropertyName(ContainedVariantName);
			if (Variant is not null)
			{
				JsonSerializer.Serialize(writer, Variant, Variant.GetType(), options);
			}
			else
			{
				JsonSerializer.Serialize(writer, Descriptor, Descriptor.GetType(), options);
			}

			writer.WriteEndObject();
		}
	}

	public sealed partial class PivotGroupByContainerDescriptor : SerializableDescriptorBase<PivotGroupByContainerDescriptor>
	{
		internal PivotGroupByContainerDescriptor(Action<PivotGroupByContainerDescriptor> configure) => configure.Invoke(this);
		public PivotGroupByContainerDescriptor() : base()
		{
		}

		private bool ContainsVariant { get; set; }

		private string ContainedVariantName { get; set; }

		private object Variant { get; set; }

		private Descriptor Descriptor { get; set; }

		private void Set<T>(Action<T> descriptorAction, string variantName)
			where T : Descriptor
		{
			if (ContainsVariant)
				throw new InvalidOperationException("A variant has already been assigned to the PivotGroupByContainerDescriptor. Only a single PivotGroupByContainer variant can be added to this container type.");
			ContainedVariantName = variantName;
			ContainsVariant = true;
			var descriptor = (T)Activator.CreateInstance(typeof(T), true);
			descriptorAction?.Invoke(descriptor);
			Descriptor = descriptor;
		}

		private void Set(object variant, string variantName)
		{
			if (ContainsVariant)
				throw new Exception("A variant has already been assigned to the PivotGroupByContainerDescriptor. Only a single PivotGroupByContainer variant can be added to this container type.");
			Variant = variant;
			ContainedVariantName = variantName;
			ContainsVariant = true;
		}

		public void DateHistogram(Aggregations.DateHistogramAggregation variant) => Set(variant, "date_histogram");
		public void DateHistogram(Action<Aggregations.DateHistogramAggregationDescriptor> configure) => Set(configure, "date_histogram");
		public void DateHistogram<TDocument>(Action<Aggregations.DateHistogramAggregationDescriptor<TDocument>> configure) => Set(configure, "date_histogram");
		public void Histogram(Aggregations.HistogramAggregation variant) => Set(variant, "histogram");
		public void Histogram(Action<Aggregations.HistogramAggregationDescriptor> configure) => Set(configure, "histogram");
		public void Histogram<TDocument>(Action<Aggregations.HistogramAggregationDescriptor<TDocument>> configure) => Set(configure, "histogram");
		public void Terms(Aggregations.TermsAggregation variant) => Set(variant, "terms");
		public void Terms(Action<Aggregations.TermsAggregationDescriptor> configure) => Set(configure, "terms");
		public void Terms<TDocument>(Action<Aggregations.TermsAggregationDescriptor<TDocument>> configure) => Set(configure, "terms");
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			if (!ContainsVariant)
			{
				writer.WriteNullValue();
				return;
			}

			writer.WriteStartObject();
			writer.WritePropertyName(ContainedVariantName);
			if (Variant is not null)
			{
				JsonSerializer.Serialize(writer, Variant, Variant.GetType(), options);
			}
			else
			{
				JsonSerializer.Serialize(writer, Descriptor, Descriptor.GetType(), options);
			}

			writer.WriteEndObject();
		}
	}
}