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
namespace Elastic.Clients.Elasticsearch.Cluster
{
	public partial class CharFilterTypes
	{
		[JsonInclude]
		[JsonPropertyName("analyzer_types")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Cluster.FieldTypes> AnalyzerTypes { get; init; }

		[JsonInclude]
		[JsonPropertyName("built_in_analyzers")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Cluster.FieldTypes> BuiltInAnalyzers { get; init; }

		[JsonInclude]
		[JsonPropertyName("built_in_char_filters")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Cluster.FieldTypes> BuiltInCharFilters { get; init; }

		[JsonInclude]
		[JsonPropertyName("built_in_filters")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Cluster.FieldTypes> BuiltInFilters { get; init; }

		[JsonInclude]
		[JsonPropertyName("built_in_tokenizers")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Cluster.FieldTypes> BuiltInTokenizers { get; init; }

		[JsonInclude]
		[JsonPropertyName("char_filter_types")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Cluster.FieldTypes> CharFilterTypesTemp { get; init; }

		[JsonInclude]
		[JsonPropertyName("filter_types")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Cluster.FieldTypes> FilterTypes { get; init; }

		[JsonInclude]
		[JsonPropertyName("tokenizer_types")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Cluster.FieldTypes> TokenizerTypes { get; init; }
	}
}