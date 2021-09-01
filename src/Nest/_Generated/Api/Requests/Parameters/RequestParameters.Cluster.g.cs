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
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;

#nullable restore
namespace Nest.Cluster
{
	public class AllocationExplainRequestParameters : RequestParameters<AllocationExplainRequestParameters>
	{
		[JsonIgnore]
		public bool? IncludeDiskInfo { get => Q<bool?>("include_disk_info"); set => Q("include_disk_info", value); }

		[JsonIgnore]
		public bool? IncludeYesDecisions { get => Q<bool?>("include_yes_decisions"); set => Q("include_yes_decisions", value); }
	}

	public class DeleteComponentTemplateRequestParameters : RequestParameters<DeleteComponentTemplateRequestParameters>
	{
		[JsonIgnore]
		public Nest.Time? MasterTimeout { get => Q<Nest.Time?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonIgnore]
		public Nest.Time? Timeout { get => Q<Nest.Time?>("timeout"); set => Q("timeout", value); }
	}

	public class DeleteVotingConfigExclusionsRequestParameters : RequestParameters<DeleteVotingConfigExclusionsRequestParameters>
	{
		[JsonIgnore]
		public bool? WaitForRemoval { get => Q<bool?>("wait_for_removal"); set => Q("wait_for_removal", value); }
	}

	public class ExistsComponentTemplateRequestParameters : RequestParameters<ExistsComponentTemplateRequestParameters>
	{
		[JsonIgnore]
		public Nest.Time? MasterTimeout { get => Q<Nest.Time?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonIgnore]
		public bool? Local { get => Q<bool?>("local"); set => Q("local", value); }
	}

	public class GetComponentTemplateRequestParameters : RequestParameters<GetComponentTemplateRequestParameters>
	{
		[JsonIgnore]
		public bool? FlatSettings { get => Q<bool?>("flat_settings"); set => Q("flat_settings", value); }

		[JsonIgnore]
		public bool? Local { get => Q<bool?>("local"); set => Q("local", value); }

		[JsonIgnore]
		public Nest.Time? MasterTimeout { get => Q<Nest.Time?>("master_timeout"); set => Q("master_timeout", value); }
	}

	public class GetSettingsRequestParameters : RequestParameters<GetSettingsRequestParameters>
	{
		[JsonIgnore]
		public bool? FlatSettings { get => Q<bool?>("flat_settings"); set => Q("flat_settings", value); }

		[JsonIgnore]
		public bool? IncludeDefaults { get => Q<bool?>("include_defaults"); set => Q("include_defaults", value); }

		[JsonIgnore]
		public Nest.Time? MasterTimeout { get => Q<Nest.Time?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonIgnore]
		public Nest.Time? Timeout { get => Q<Nest.Time?>("timeout"); set => Q("timeout", value); }
	}

	public class HealthRequestParameters : RequestParameters<HealthRequestParameters>
	{
		[JsonIgnore]
		public Nest.ExpandWildcards? ExpandWildcards { get => Q<Nest.ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }

		[JsonIgnore]
		public Nest.Level? Level { get => Q<Nest.Level?>("level"); set => Q("level", value); }

		[JsonIgnore]
		public bool? Local { get => Q<bool?>("local"); set => Q("local", value); }

		[JsonIgnore]
		public Nest.Time? MasterTimeout { get => Q<Nest.Time?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonIgnore]
		public Nest.Time? Timeout { get => Q<Nest.Time?>("timeout"); set => Q("timeout", value); }

		[JsonIgnore]
		public Nest.WaitForActiveShards? WaitForActiveShards { get => Q<Nest.WaitForActiveShards?>("wait_for_active_shards"); set => Q("wait_for_active_shards", value); }

		[JsonIgnore]
		public Nest.WaitForEvents? WaitForEvents { get => Q<Nest.WaitForEvents?>("wait_for_events"); set => Q("wait_for_events", value); }

		[JsonIgnore]
		public string? WaitForNodes { get => Q<string?>("wait_for_nodes"); set => Q("wait_for_nodes", value); }

		[JsonIgnore]
		public bool? WaitForNoInitializingShards { get => Q<bool?>("wait_for_no_initializing_shards"); set => Q("wait_for_no_initializing_shards", value); }

		[JsonIgnore]
		public bool? WaitForNoRelocatingShards { get => Q<bool?>("wait_for_no_relocating_shards"); set => Q("wait_for_no_relocating_shards", value); }

		[JsonIgnore]
		public Nest.WaitForStatus? WaitForStatus { get => Q<Nest.WaitForStatus?>("wait_for_status"); set => Q("wait_for_status", value); }
	}

	public class PendingTasksRequestParameters : RequestParameters<PendingTasksRequestParameters>
	{
		[JsonIgnore]
		public bool? Local { get => Q<bool?>("local"); set => Q("local", value); }

		[JsonIgnore]
		public Nest.Time? MasterTimeout { get => Q<Nest.Time?>("master_timeout"); set => Q("master_timeout", value); }
	}

	public class PostVotingConfigExclusionsRequestParameters : RequestParameters<PostVotingConfigExclusionsRequestParameters>
	{
		[JsonIgnore]
		public Nest.Names? NodeNames { get => Q<Nest.Names?>("node_names"); set => Q("node_names", value); }

		[JsonIgnore]
		public Nest.Ids? NodeIds { get => Q<Nest.Ids?>("node_ids"); set => Q("node_ids", value); }

		[JsonIgnore]
		public Nest.Time? Timeout { get => Q<Nest.Time?>("timeout"); set => Q("timeout", value); }
	}

	public class PutComponentTemplateRequestParameters : RequestParameters<PutComponentTemplateRequestParameters>
	{
		[JsonIgnore]
		public bool? Create { get => Q<bool?>("create"); set => Q("create", value); }

		[JsonIgnore]
		public Nest.Time? MasterTimeout { get => Q<Nest.Time?>("master_timeout"); set => Q("master_timeout", value); }
	}

	public class PutSettingsRequestParameters : RequestParameters<PutSettingsRequestParameters>
	{
		[JsonIgnore]
		public bool? FlatSettings { get => Q<bool?>("flat_settings"); set => Q("flat_settings", value); }

		[JsonIgnore]
		public Nest.Time? MasterTimeout { get => Q<Nest.Time?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonIgnore]
		public Nest.Time? Timeout { get => Q<Nest.Time?>("timeout"); set => Q("timeout", value); }
	}

	public class RemoteInfoRequestParameters : RequestParameters<RemoteInfoRequestParameters>
	{
	}

	public class RerouteRequestParameters : RequestParameters<RerouteRequestParameters>
	{
		[JsonIgnore]
		public bool? DryRun { get => Q<bool?>("dry_run"); set => Q("dry_run", value); }

		[JsonIgnore]
		public bool? Explain { get => Q<bool?>("explain"); set => Q("explain", value); }

		[JsonIgnore]
		public Nest.Metrics? Metric { get => Q<Nest.Metrics?>("metric"); set => Q("metric", value); }

		[JsonIgnore]
		public bool? RetryFailed { get => Q<bool?>("retry_failed"); set => Q("retry_failed", value); }

		[JsonIgnore]
		public Nest.Time? MasterTimeout { get => Q<Nest.Time?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonIgnore]
		public Nest.Time? Timeout { get => Q<Nest.Time?>("timeout"); set => Q("timeout", value); }
	}

	public class StateRequestParameters : RequestParameters<StateRequestParameters>
	{
		[JsonIgnore]
		public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

		[JsonIgnore]
		public Nest.ExpandWildcards? ExpandWildcards { get => Q<Nest.ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }

		[JsonIgnore]
		public bool? FlatSettings { get => Q<bool?>("flat_settings"); set => Q("flat_settings", value); }

		[JsonIgnore]
		public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

		[JsonIgnore]
		public bool? Local { get => Q<bool?>("local"); set => Q("local", value); }

		[JsonIgnore]
		public Nest.Time? MasterTimeout { get => Q<Nest.Time?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonIgnore]
		public Nest.VersionNumber? WaitForMetadataVersion { get => Q<Nest.VersionNumber?>("wait_for_metadata_version"); set => Q("wait_for_metadata_version", value); }

		[JsonIgnore]
		public Nest.Time? WaitForTimeout { get => Q<Nest.Time?>("wait_for_timeout"); set => Q("wait_for_timeout", value); }
	}

	public class StatsRequestParameters : RequestParameters<StatsRequestParameters>
	{
		[JsonIgnore]
		public bool? FlatSettings { get => Q<bool?>("flat_settings"); set => Q("flat_settings", value); }

		[JsonIgnore]
		public Nest.Time? Timeout { get => Q<Nest.Time?>("timeout"); set => Q("timeout", value); }
	}
}