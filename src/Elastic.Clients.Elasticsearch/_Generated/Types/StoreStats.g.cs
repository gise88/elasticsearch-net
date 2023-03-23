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

namespace Elastic.Clients.Elasticsearch;

public sealed partial class StoreStats
{
	[JsonInclude, JsonPropertyName("reserved")]
	public Elastic.Clients.Elasticsearch.ByteSize? Reserved { get; init; }
	[JsonInclude, JsonPropertyName("reserved_in_bytes")]
	public long ReservedInBytes { get; init; }
	[JsonInclude, JsonPropertyName("size")]
	public Elastic.Clients.Elasticsearch.ByteSize? Size { get; init; }
	[JsonInclude, JsonPropertyName("size_in_bytes")]
	public long SizeInBytes { get; init; }
	[JsonInclude, JsonPropertyName("total_data_set_size")]
	public Elastic.Clients.Elasticsearch.ByteSize? TotalDataSetSize { get; init; }
	[JsonInclude, JsonPropertyName("total_data_set_size_in_bytes")]
	public long? TotalDataSetSizeInBytes { get; init; }
}