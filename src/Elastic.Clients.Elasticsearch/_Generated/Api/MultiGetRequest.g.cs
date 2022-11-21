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
using Elastic.Clients.Elasticsearch.Requests;
using Elastic.Clients.Elasticsearch.Serialization;
using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch;
public sealed class MultiGetRequestParameters : RequestParameters
{
	[JsonIgnore]
	public string? Preference { get => Q<string?>("preference"); set => Q("preference", value); }

	[JsonIgnore]
	public bool? Realtime { get => Q<bool?>("realtime"); set => Q("realtime", value); }

	[JsonIgnore]
	public bool? Refresh { get => Q<bool?>("refresh"); set => Q("refresh", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Routing? Routing { get => Q<Elastic.Clients.Elasticsearch.Routing?>("routing"); set => Q("routing", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Core.Search.SourceConfigParam? Source { get => Q<Elastic.Clients.Elasticsearch.Core.Search.SourceConfigParam?>("_source"); set => Q("_source", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Fields? SourceExcludes { get => Q<Elastic.Clients.Elasticsearch.Fields?>("_source_excludes"); set => Q("_source_excludes", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Fields? SourceIncludes { get => Q<Elastic.Clients.Elasticsearch.Fields?>("_source_includes"); set => Q("_source_includes", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Fields? StoredFields { get => Q<Elastic.Clients.Elasticsearch.Fields?>("stored_fields"); set => Q("stored_fields", value); }
}

public sealed partial class MultiGetRequest : PlainRequest<MultiGetRequestParameters>
{
	public MultiGetRequest()
	{
	}

	public MultiGetRequest(Elastic.Clients.Elasticsearch.IndexName? index) : base(r => r.Optional("index", index))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceMget;
	internal override HttpMethod HttpMethod => HttpMethod.POST;
	internal override bool SupportsBody => true;
	[JsonIgnore]
	public string? Preference { get => Q<string?>("preference"); set => Q("preference", value); }

	[JsonIgnore]
	public bool? Realtime { get => Q<bool?>("realtime"); set => Q("realtime", value); }

	[JsonIgnore]
	public bool? Refresh { get => Q<bool?>("refresh"); set => Q("refresh", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Routing? Routing { get => Q<Elastic.Clients.Elasticsearch.Routing?>("routing"); set => Q("routing", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Core.Search.SourceConfigParam? Source { get => Q<Elastic.Clients.Elasticsearch.Core.Search.SourceConfigParam?>("_source"); set => Q("_source", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Fields? SourceExcludes { get => Q<Elastic.Clients.Elasticsearch.Fields?>("_source_excludes"); set => Q("_source_excludes", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Fields? SourceIncludes { get => Q<Elastic.Clients.Elasticsearch.Fields?>("_source_includes"); set => Q("_source_includes", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Fields? StoredFields { get => Q<Elastic.Clients.Elasticsearch.Fields?>("stored_fields"); set => Q("stored_fields", value); }

	[JsonInclude]
	[JsonPropertyName("docs")]
	public ICollection<Elastic.Clients.Elasticsearch.Core.MGet.MultiGetOperation>? Docs { get; set; }

	[JsonInclude]
	[JsonPropertyName("ids")]
	public Elastic.Clients.Elasticsearch.Ids? Ids { get; set; }
}

public sealed partial class MultiGetRequestDescriptor<TDocument> : RequestDescriptor<MultiGetRequestDescriptor<TDocument>, MultiGetRequestParameters>
{
	internal MultiGetRequestDescriptor(Action<MultiGetRequestDescriptor<TDocument>> configure) => configure.Invoke(this);
	public MultiGetRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceMget;
	internal override HttpMethod HttpMethod => HttpMethod.POST;
	internal override bool SupportsBody => true;
	public MultiGetRequestDescriptor<TDocument> Source(Elastic.Clients.Elasticsearch.Core.Search.SourceConfigParam? source) => Qs("_source", source);
	public MultiGetRequestDescriptor<TDocument> SourceExcludes(Elastic.Clients.Elasticsearch.Fields? sourceExcludes) => Qs("_source_excludes", sourceExcludes);
	public MultiGetRequestDescriptor<TDocument> SourceIncludes(Elastic.Clients.Elasticsearch.Fields? sourceIncludes) => Qs("_source_includes", sourceIncludes);
	public MultiGetRequestDescriptor<TDocument> Preference(string? preference) => Qs("preference", preference);
	public MultiGetRequestDescriptor<TDocument> Realtime(bool? realtime = true) => Qs("realtime", realtime);
	public MultiGetRequestDescriptor<TDocument> Refresh(bool? refresh = true) => Qs("refresh", refresh);
	public MultiGetRequestDescriptor<TDocument> Routing(Elastic.Clients.Elasticsearch.Routing? routing) => Qs("routing", routing);
	public MultiGetRequestDescriptor<TDocument> StoredFields(Elastic.Clients.Elasticsearch.Fields? storedFields) => Qs("stored_fields", storedFields);
	public MultiGetRequestDescriptor<TDocument> Index(Elastic.Clients.Elasticsearch.IndexName? index)
	{
		RouteValues.Optional("index", index);
		return Self;
	}

	private ICollection<Elastic.Clients.Elasticsearch.Core.MGet.MultiGetOperation>? DocsValue { get; set; }

	private Core.MGet.MultiGetOperationDescriptor DocsDescriptor { get; set; }

	private Action<Core.MGet.MultiGetOperationDescriptor> DocsDescriptorAction { get; set; }

	private Action<Core.MGet.MultiGetOperationDescriptor>[] DocsDescriptorActions { get; set; }

	private Elastic.Clients.Elasticsearch.Ids? IdsValue { get; set; }

	public MultiGetRequestDescriptor<TDocument> Docs(ICollection<Elastic.Clients.Elasticsearch.Core.MGet.MultiGetOperation>? docs)
	{
		DocsDescriptor = null;
		DocsDescriptorAction = null;
		DocsDescriptorActions = null;
		DocsValue = docs;
		return Self;
	}

	public MultiGetRequestDescriptor<TDocument> Docs(Core.MGet.MultiGetOperationDescriptor descriptor)
	{
		DocsValue = null;
		DocsDescriptorAction = null;
		DocsDescriptorActions = null;
		DocsDescriptor = descriptor;
		return Self;
	}

	public MultiGetRequestDescriptor<TDocument> Docs(Action<Core.MGet.MultiGetOperationDescriptor> configure)
	{
		DocsValue = null;
		DocsDescriptor = null;
		DocsDescriptorActions = null;
		DocsDescriptorAction = configure;
		return Self;
	}

	public MultiGetRequestDescriptor<TDocument> Docs(params Action<Core.MGet.MultiGetOperationDescriptor>[] configure)
	{
		DocsValue = null;
		DocsDescriptor = null;
		DocsDescriptorAction = null;
		DocsDescriptorActions = configure;
		return Self;
	}

	public MultiGetRequestDescriptor<TDocument> Ids(Elastic.Clients.Elasticsearch.Ids? ids)
	{
		IdsValue = ids;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (DocsDescriptor is not null)
		{
			writer.WritePropertyName("docs");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, DocsDescriptor, options);
			writer.WriteEndArray();
		}
		else if (DocsDescriptorAction is not null)
		{
			writer.WritePropertyName("docs");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, new Core.MGet.MultiGetOperationDescriptor(DocsDescriptorAction), options);
			writer.WriteEndArray();
		}
		else if (DocsDescriptorActions is not null)
		{
			writer.WritePropertyName("docs");
			writer.WriteStartArray();
			foreach (var action in DocsDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Core.MGet.MultiGetOperationDescriptor(action), options);
			}

			writer.WriteEndArray();
		}
		else if (DocsValue is not null)
		{
			writer.WritePropertyName("docs");
			JsonSerializer.Serialize(writer, DocsValue, options);
		}

		if (IdsValue is not null)
		{
			writer.WritePropertyName("ids");
			JsonSerializer.Serialize(writer, IdsValue, options);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class MultiGetRequestDescriptor : RequestDescriptor<MultiGetRequestDescriptor, MultiGetRequestParameters>
{
	internal MultiGetRequestDescriptor(Action<MultiGetRequestDescriptor> configure) => configure.Invoke(this);
	public MultiGetRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceMget;
	internal override HttpMethod HttpMethod => HttpMethod.POST;
	internal override bool SupportsBody => true;
	public MultiGetRequestDescriptor Source(Elastic.Clients.Elasticsearch.Core.Search.SourceConfigParam? source) => Qs("_source", source);
	public MultiGetRequestDescriptor SourceExcludes(Elastic.Clients.Elasticsearch.Fields? sourceExcludes) => Qs("_source_excludes", sourceExcludes);
	public MultiGetRequestDescriptor SourceIncludes(Elastic.Clients.Elasticsearch.Fields? sourceIncludes) => Qs("_source_includes", sourceIncludes);
	public MultiGetRequestDescriptor Preference(string? preference) => Qs("preference", preference);
	public MultiGetRequestDescriptor Realtime(bool? realtime = true) => Qs("realtime", realtime);
	public MultiGetRequestDescriptor Refresh(bool? refresh = true) => Qs("refresh", refresh);
	public MultiGetRequestDescriptor Routing(Elastic.Clients.Elasticsearch.Routing? routing) => Qs("routing", routing);
	public MultiGetRequestDescriptor StoredFields(Elastic.Clients.Elasticsearch.Fields? storedFields) => Qs("stored_fields", storedFields);
	public MultiGetRequestDescriptor Index(Elastic.Clients.Elasticsearch.IndexName? index)
	{
		RouteValues.Optional("index", index);
		return Self;
	}

	private ICollection<Elastic.Clients.Elasticsearch.Core.MGet.MultiGetOperation>? DocsValue { get; set; }

	private Core.MGet.MultiGetOperationDescriptor DocsDescriptor { get; set; }

	private Action<Core.MGet.MultiGetOperationDescriptor> DocsDescriptorAction { get; set; }

	private Action<Core.MGet.MultiGetOperationDescriptor>[] DocsDescriptorActions { get; set; }

	private Elastic.Clients.Elasticsearch.Ids? IdsValue { get; set; }

	public MultiGetRequestDescriptor Docs(ICollection<Elastic.Clients.Elasticsearch.Core.MGet.MultiGetOperation>? docs)
	{
		DocsDescriptor = null;
		DocsDescriptorAction = null;
		DocsDescriptorActions = null;
		DocsValue = docs;
		return Self;
	}

	public MultiGetRequestDescriptor Docs(Core.MGet.MultiGetOperationDescriptor descriptor)
	{
		DocsValue = null;
		DocsDescriptorAction = null;
		DocsDescriptorActions = null;
		DocsDescriptor = descriptor;
		return Self;
	}

	public MultiGetRequestDescriptor Docs(Action<Core.MGet.MultiGetOperationDescriptor> configure)
	{
		DocsValue = null;
		DocsDescriptor = null;
		DocsDescriptorActions = null;
		DocsDescriptorAction = configure;
		return Self;
	}

	public MultiGetRequestDescriptor Docs(params Action<Core.MGet.MultiGetOperationDescriptor>[] configure)
	{
		DocsValue = null;
		DocsDescriptor = null;
		DocsDescriptorAction = null;
		DocsDescriptorActions = configure;
		return Self;
	}

	public MultiGetRequestDescriptor Ids(Elastic.Clients.Elasticsearch.Ids? ids)
	{
		IdsValue = ids;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (DocsDescriptor is not null)
		{
			writer.WritePropertyName("docs");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, DocsDescriptor, options);
			writer.WriteEndArray();
		}
		else if (DocsDescriptorAction is not null)
		{
			writer.WritePropertyName("docs");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, new Core.MGet.MultiGetOperationDescriptor(DocsDescriptorAction), options);
			writer.WriteEndArray();
		}
		else if (DocsDescriptorActions is not null)
		{
			writer.WritePropertyName("docs");
			writer.WriteStartArray();
			foreach (var action in DocsDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Core.MGet.MultiGetOperationDescriptor(action), options);
			}

			writer.WriteEndArray();
		}
		else if (DocsValue is not null)
		{
			writer.WritePropertyName("docs");
			JsonSerializer.Serialize(writer, DocsValue, options);
		}

		if (IdsValue is not null)
		{
			writer.WritePropertyName("ids");
			JsonSerializer.Serialize(writer, IdsValue, options);
		}

		writer.WriteEndObject();
	}
}