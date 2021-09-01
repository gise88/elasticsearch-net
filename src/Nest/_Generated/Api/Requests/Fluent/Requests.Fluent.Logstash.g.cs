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
namespace Nest.Logstash
{
	public partial class DeletePipelineDescriptor : RequestDescriptorBase<DeletePipelineDescriptor, DeletePipelineRequestParameters, IDeletePipelineRequest>, IDeletePipelineRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.LogstashDeletePipeline;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
		///<summary>/_logstash/pipeline/{id}</summary>
        public DeletePipelineDescriptor(Nest.Id id) : base(r => r.Required("id", id))
		{
		}
	}

	public partial class GetPipelineDescriptor : RequestDescriptorBase<GetPipelineDescriptor, GetPipelineRequestParameters, IGetPipelineRequest>, IGetPipelineRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.LogstashGetPipeline;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		///<summary>/_logstash/pipeline/{id}</summary>
        public GetPipelineDescriptor(Nest.Ids id) : base(r => r.Required("id", id))
		{
		}
	}

	public partial class PutPipelineDescriptor : RequestDescriptorBase<PutPipelineDescriptor, PutPipelineRequestParameters, IPutPipelineRequest>, IPutPipelineRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.LogstashPutPipeline;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => false;
		///<summary>/_logstash/pipeline/{id}</summary>
        public PutPipelineDescriptor(Nest.Id id) : base(r => r.Required("id", id))
		{
		}
	}
}