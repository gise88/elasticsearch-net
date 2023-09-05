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

namespace Elastic.Clients.Elasticsearch.Ingest;

public sealed partial class Pipeline
{
	/// <summary>
	/// <para>Description of the ingest pipeline.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("description")]
	public string? Description { get; set; }

	/// <summary>
	/// <para>Processors to run immediately after a processor failure.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("on_failure")]
	public ICollection<Elastic.Clients.Elasticsearch.Ingest.Processor>? OnFailure { get; set; }

	/// <summary>
	/// <para>Processors used to perform transformations on documents before indexing.<br/>Processors run sequentially in the order specified.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("processors")]
	public ICollection<Elastic.Clients.Elasticsearch.Ingest.Processor>? Processors { get; set; }

	/// <summary>
	/// <para>Version number used by external systems to track ingest pipelines.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("version")]
	public long? Version { get; set; }
}

public sealed partial class PipelineDescriptor<TDocument> : SerializableDescriptor<PipelineDescriptor<TDocument>>
{
	internal PipelineDescriptor(Action<PipelineDescriptor<TDocument>> configure) => configure.Invoke(this);

	public PipelineDescriptor() : base()
	{
	}

	private ICollection<Elastic.Clients.Elasticsearch.Ingest.Processor>? OnFailureValue { get; set; }
	private ProcessorDescriptor<TDocument> OnFailureDescriptor { get; set; }
	private Action<ProcessorDescriptor<TDocument>> OnFailureDescriptorAction { get; set; }
	private Action<ProcessorDescriptor<TDocument>>[] OnFailureDescriptorActions { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Ingest.Processor>? ProcessorsValue { get; set; }
	private ProcessorDescriptor<TDocument> ProcessorsDescriptor { get; set; }
	private Action<ProcessorDescriptor<TDocument>> ProcessorsDescriptorAction { get; set; }
	private Action<ProcessorDescriptor<TDocument>>[] ProcessorsDescriptorActions { get; set; }
	private string? DescriptionValue { get; set; }
	private long? VersionValue { get; set; }

	/// <summary>
	/// <para>Processors to run immediately after a processor failure.</para>
	/// </summary>
	public PipelineDescriptor<TDocument> OnFailure(ICollection<Elastic.Clients.Elasticsearch.Ingest.Processor>? onFailure)
	{
		OnFailureDescriptor = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = null;
		OnFailureValue = onFailure;
		return Self;
	}

	public PipelineDescriptor<TDocument> OnFailure(ProcessorDescriptor<TDocument> descriptor)
	{
		OnFailureValue = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = null;
		OnFailureDescriptor = descriptor;
		return Self;
	}

	public PipelineDescriptor<TDocument> OnFailure(Action<ProcessorDescriptor<TDocument>> configure)
	{
		OnFailureValue = null;
		OnFailureDescriptor = null;
		OnFailureDescriptorActions = null;
		OnFailureDescriptorAction = configure;
		return Self;
	}

	public PipelineDescriptor<TDocument> OnFailure(params Action<ProcessorDescriptor<TDocument>>[] configure)
	{
		OnFailureValue = null;
		OnFailureDescriptor = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = configure;
		return Self;
	}

	/// <summary>
	/// <para>Processors used to perform transformations on documents before indexing.<br/>Processors run sequentially in the order specified.</para>
	/// </summary>
	public PipelineDescriptor<TDocument> Processors(ICollection<Elastic.Clients.Elasticsearch.Ingest.Processor>? processors)
	{
		ProcessorsDescriptor = null;
		ProcessorsDescriptorAction = null;
		ProcessorsDescriptorActions = null;
		ProcessorsValue = processors;
		return Self;
	}

	public PipelineDescriptor<TDocument> Processors(ProcessorDescriptor<TDocument> descriptor)
	{
		ProcessorsValue = null;
		ProcessorsDescriptorAction = null;
		ProcessorsDescriptorActions = null;
		ProcessorsDescriptor = descriptor;
		return Self;
	}

	public PipelineDescriptor<TDocument> Processors(Action<ProcessorDescriptor<TDocument>> configure)
	{
		ProcessorsValue = null;
		ProcessorsDescriptor = null;
		ProcessorsDescriptorActions = null;
		ProcessorsDescriptorAction = configure;
		return Self;
	}

	public PipelineDescriptor<TDocument> Processors(params Action<ProcessorDescriptor<TDocument>>[] configure)
	{
		ProcessorsValue = null;
		ProcessorsDescriptor = null;
		ProcessorsDescriptorAction = null;
		ProcessorsDescriptorActions = configure;
		return Self;
	}

	/// <summary>
	/// <para>Description of the ingest pipeline.</para>
	/// </summary>
	public PipelineDescriptor<TDocument> Description(string? description)
	{
		DescriptionValue = description;
		return Self;
	}

	/// <summary>
	/// <para>Version number used by external systems to track ingest pipelines.</para>
	/// </summary>
	public PipelineDescriptor<TDocument> Version(long? version)
	{
		VersionValue = version;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (OnFailureDescriptor is not null)
		{
			writer.WritePropertyName("on_failure");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, OnFailureDescriptor, options);
			writer.WriteEndArray();
		}
		else if (OnFailureDescriptorAction is not null)
		{
			writer.WritePropertyName("on_failure");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, new ProcessorDescriptor<TDocument>(OnFailureDescriptorAction), options);
			writer.WriteEndArray();
		}
		else if (OnFailureDescriptorActions is not null)
		{
			writer.WritePropertyName("on_failure");
			writer.WriteStartArray();
			foreach (var action in OnFailureDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new ProcessorDescriptor<TDocument>(action), options);
			}

			writer.WriteEndArray();
		}
		else if (OnFailureValue is not null)
		{
			writer.WritePropertyName("on_failure");
			JsonSerializer.Serialize(writer, OnFailureValue, options);
		}

		if (ProcessorsDescriptor is not null)
		{
			writer.WritePropertyName("processors");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, ProcessorsDescriptor, options);
			writer.WriteEndArray();
		}
		else if (ProcessorsDescriptorAction is not null)
		{
			writer.WritePropertyName("processors");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, new ProcessorDescriptor<TDocument>(ProcessorsDescriptorAction), options);
			writer.WriteEndArray();
		}
		else if (ProcessorsDescriptorActions is not null)
		{
			writer.WritePropertyName("processors");
			writer.WriteStartArray();
			foreach (var action in ProcessorsDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new ProcessorDescriptor<TDocument>(action), options);
			}

			writer.WriteEndArray();
		}
		else if (ProcessorsValue is not null)
		{
			writer.WritePropertyName("processors");
			JsonSerializer.Serialize(writer, ProcessorsValue, options);
		}

		if (!string.IsNullOrEmpty(DescriptionValue))
		{
			writer.WritePropertyName("description");
			writer.WriteStringValue(DescriptionValue);
		}

		if (VersionValue is not null)
		{
			writer.WritePropertyName("version");
			JsonSerializer.Serialize(writer, VersionValue, options);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class PipelineDescriptor : SerializableDescriptor<PipelineDescriptor>
{
	internal PipelineDescriptor(Action<PipelineDescriptor> configure) => configure.Invoke(this);

	public PipelineDescriptor() : base()
	{
	}

	private ICollection<Elastic.Clients.Elasticsearch.Ingest.Processor>? OnFailureValue { get; set; }
	private ProcessorDescriptor OnFailureDescriptor { get; set; }
	private Action<ProcessorDescriptor> OnFailureDescriptorAction { get; set; }
	private Action<ProcessorDescriptor>[] OnFailureDescriptorActions { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Ingest.Processor>? ProcessorsValue { get; set; }
	private ProcessorDescriptor ProcessorsDescriptor { get; set; }
	private Action<ProcessorDescriptor> ProcessorsDescriptorAction { get; set; }
	private Action<ProcessorDescriptor>[] ProcessorsDescriptorActions { get; set; }
	private string? DescriptionValue { get; set; }
	private long? VersionValue { get; set; }

	/// <summary>
	/// <para>Processors to run immediately after a processor failure.</para>
	/// </summary>
	public PipelineDescriptor OnFailure(ICollection<Elastic.Clients.Elasticsearch.Ingest.Processor>? onFailure)
	{
		OnFailureDescriptor = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = null;
		OnFailureValue = onFailure;
		return Self;
	}

	public PipelineDescriptor OnFailure(ProcessorDescriptor descriptor)
	{
		OnFailureValue = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = null;
		OnFailureDescriptor = descriptor;
		return Self;
	}

	public PipelineDescriptor OnFailure(Action<ProcessorDescriptor> configure)
	{
		OnFailureValue = null;
		OnFailureDescriptor = null;
		OnFailureDescriptorActions = null;
		OnFailureDescriptorAction = configure;
		return Self;
	}

	public PipelineDescriptor OnFailure(params Action<ProcessorDescriptor>[] configure)
	{
		OnFailureValue = null;
		OnFailureDescriptor = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = configure;
		return Self;
	}

	/// <summary>
	/// <para>Processors used to perform transformations on documents before indexing.<br/>Processors run sequentially in the order specified.</para>
	/// </summary>
	public PipelineDescriptor Processors(ICollection<Elastic.Clients.Elasticsearch.Ingest.Processor>? processors)
	{
		ProcessorsDescriptor = null;
		ProcessorsDescriptorAction = null;
		ProcessorsDescriptorActions = null;
		ProcessorsValue = processors;
		return Self;
	}

	public PipelineDescriptor Processors(ProcessorDescriptor descriptor)
	{
		ProcessorsValue = null;
		ProcessorsDescriptorAction = null;
		ProcessorsDescriptorActions = null;
		ProcessorsDescriptor = descriptor;
		return Self;
	}

	public PipelineDescriptor Processors(Action<ProcessorDescriptor> configure)
	{
		ProcessorsValue = null;
		ProcessorsDescriptor = null;
		ProcessorsDescriptorActions = null;
		ProcessorsDescriptorAction = configure;
		return Self;
	}

	public PipelineDescriptor Processors(params Action<ProcessorDescriptor>[] configure)
	{
		ProcessorsValue = null;
		ProcessorsDescriptor = null;
		ProcessorsDescriptorAction = null;
		ProcessorsDescriptorActions = configure;
		return Self;
	}

	/// <summary>
	/// <para>Description of the ingest pipeline.</para>
	/// </summary>
	public PipelineDescriptor Description(string? description)
	{
		DescriptionValue = description;
		return Self;
	}

	/// <summary>
	/// <para>Version number used by external systems to track ingest pipelines.</para>
	/// </summary>
	public PipelineDescriptor Version(long? version)
	{
		VersionValue = version;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (OnFailureDescriptor is not null)
		{
			writer.WritePropertyName("on_failure");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, OnFailureDescriptor, options);
			writer.WriteEndArray();
		}
		else if (OnFailureDescriptorAction is not null)
		{
			writer.WritePropertyName("on_failure");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, new ProcessorDescriptor(OnFailureDescriptorAction), options);
			writer.WriteEndArray();
		}
		else if (OnFailureDescriptorActions is not null)
		{
			writer.WritePropertyName("on_failure");
			writer.WriteStartArray();
			foreach (var action in OnFailureDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new ProcessorDescriptor(action), options);
			}

			writer.WriteEndArray();
		}
		else if (OnFailureValue is not null)
		{
			writer.WritePropertyName("on_failure");
			JsonSerializer.Serialize(writer, OnFailureValue, options);
		}

		if (ProcessorsDescriptor is not null)
		{
			writer.WritePropertyName("processors");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, ProcessorsDescriptor, options);
			writer.WriteEndArray();
		}
		else if (ProcessorsDescriptorAction is not null)
		{
			writer.WritePropertyName("processors");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, new ProcessorDescriptor(ProcessorsDescriptorAction), options);
			writer.WriteEndArray();
		}
		else if (ProcessorsDescriptorActions is not null)
		{
			writer.WritePropertyName("processors");
			writer.WriteStartArray();
			foreach (var action in ProcessorsDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new ProcessorDescriptor(action), options);
			}

			writer.WriteEndArray();
		}
		else if (ProcessorsValue is not null)
		{
			writer.WritePropertyName("processors");
			JsonSerializer.Serialize(writer, ProcessorsValue, options);
		}

		if (!string.IsNullOrEmpty(DescriptionValue))
		{
			writer.WritePropertyName("description");
			writer.WriteStringValue(DescriptionValue);
		}

		if (VersionValue is not null)
		{
			writer.WritePropertyName("version");
			JsonSerializer.Serialize(writer, VersionValue, options);
		}

		writer.WriteEndObject();
	}
}