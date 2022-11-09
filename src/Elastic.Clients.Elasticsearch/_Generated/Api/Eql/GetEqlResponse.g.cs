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

using Elastic.Clients.Elasticsearch.Fluent;
using Elastic.Clients.Elasticsearch.Serialization;
using Elastic.Transport.Products.Elasticsearch;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Eql;
public sealed partial class GetEqlResponse<TEvent> : ElasticsearchResponse
{
	[JsonInclude]
	[JsonPropertyName("hits")]
	public Elastic.Clients.Elasticsearch.Eql.EqlHits<TEvent> Hits { get; init; }

	[JsonInclude]
	[JsonPropertyName("id")]
	public string? Id { get; init; }

	[JsonInclude]
	[JsonPropertyName("is_partial")]
	public bool? IsPartial { get; init; }

	[JsonInclude]
	[JsonPropertyName("is_running")]
	public bool? IsRunning { get; init; }

	[JsonInclude]
	[JsonPropertyName("timed_out")]
	public bool? TimedOut { get; init; }

	[JsonInclude]
	[JsonPropertyName("took")]
	public long? Took { get; init; }
}