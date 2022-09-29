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
namespace Elastic.Clients.Elasticsearch.Security
{
	public sealed partial class RoleTemplateQuery
	{
		[JsonInclude]
		[JsonPropertyName("template")]
		public Elastic.Clients.Elasticsearch.Security.RoleTemplateScript? Template { get; set; }
	}

	public sealed partial class RoleTemplateQueryDescriptor : SerializableDescriptorBase<RoleTemplateQueryDescriptor>
	{
		internal RoleTemplateQueryDescriptor(Action<RoleTemplateQueryDescriptor> configure) => configure.Invoke(this);
		public RoleTemplateQueryDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.Security.RoleTemplateScript? TemplateValue { get; set; }

		public RoleTemplateQueryDescriptor Template(Elastic.Clients.Elasticsearch.Security.RoleTemplateScript? template)
		{
			TemplateValue = template;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (TemplateValue is not null)
			{
				writer.WritePropertyName("template");
				JsonSerializer.Serialize(writer, TemplateValue, options);
			}

			writer.WriteEndObject();
		}
	}
}