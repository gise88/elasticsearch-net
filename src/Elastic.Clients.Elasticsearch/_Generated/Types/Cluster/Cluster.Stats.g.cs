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
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Cluster.Stats
{
	public partial class CharFilterTypes
	{
		[JsonInclude]
		[JsonPropertyName("char_filter_types")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Cluster.Stats.FieldTypes> CharFilterTypesTemp { get; init; }

		[JsonInclude]
		[JsonPropertyName("tokenizer_types")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Cluster.Stats.FieldTypes> TokenizerTypes { get; init; }

		[JsonInclude]
		[JsonPropertyName("filter_types")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Cluster.Stats.FieldTypes> FilterTypes { get; init; }

		[JsonInclude]
		[JsonPropertyName("analyzer_types")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Cluster.Stats.FieldTypes> AnalyzerTypes { get; init; }

		[JsonInclude]
		[JsonPropertyName("built_in_char_filters")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Cluster.Stats.FieldTypes> BuiltInCharFilters { get; init; }

		[JsonInclude]
		[JsonPropertyName("built_in_tokenizers")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Cluster.Stats.FieldTypes> BuiltInTokenizers { get; init; }

		[JsonInclude]
		[JsonPropertyName("built_in_filters")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Cluster.Stats.FieldTypes> BuiltInFilters { get; init; }

		[JsonInclude]
		[JsonPropertyName("built_in_analyzers")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Cluster.Stats.FieldTypes> BuiltInAnalyzers { get; init; }
	}

	public partial class ClusterFileSystem
	{
		[JsonInclude]
		[JsonPropertyName("available_in_bytes")]
		public object AvailableInBytes { get; init; }

		[JsonInclude]
		[JsonPropertyName("free_in_bytes")]
		public object FreeInBytes { get; init; }

		[JsonInclude]
		[JsonPropertyName("total_in_bytes")]
		public object TotalInBytes { get; init; }
	}

	public partial class ClusterIndices
	{
		[JsonInclude]
		[JsonPropertyName("completion")]
		public Elastic.Clients.Elasticsearch.CompletionStats Completion { get; init; }

		[JsonInclude]
		[JsonPropertyName("count")]
		public object Count { get; init; }

		[JsonInclude]
		[JsonPropertyName("docs")]
		public Elastic.Clients.Elasticsearch.DocStats Docs { get; init; }

		[JsonInclude]
		[JsonPropertyName("fielddata")]
		public Elastic.Clients.Elasticsearch.FielddataStats Fielddata { get; init; }

		[JsonInclude]
		[JsonPropertyName("query_cache")]
		public Elastic.Clients.Elasticsearch.QueryCacheStats QueryCache { get; init; }

		[JsonInclude]
		[JsonPropertyName("segments")]
		public Elastic.Clients.Elasticsearch.SegmentsStats Segments { get; init; }

		[JsonInclude]
		[JsonPropertyName("shards")]
		public Elastic.Clients.Elasticsearch.Cluster.Stats.ClusterIndicesShards Shards { get; init; }

		[JsonInclude]
		[JsonPropertyName("store")]
		public Elastic.Clients.Elasticsearch.StoreStats Store { get; init; }

		[JsonInclude]
		[JsonPropertyName("mappings")]
		public Elastic.Clients.Elasticsearch.Cluster.Stats.FieldTypesMappings Mappings { get; init; }

		[JsonInclude]
		[JsonPropertyName("analysis")]
		public Elastic.Clients.Elasticsearch.Cluster.Stats.CharFilterTypes Analysis { get; init; }

		[JsonInclude]
		[JsonPropertyName("versions")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Cluster.Stats.IndicesVersions>? Versions { get; init; }
	}

	public partial class ClusterIndicesShards
	{
		[JsonInclude]
		[JsonPropertyName("index")]
		public Elastic.Clients.Elasticsearch.Cluster.Stats.ClusterIndicesShardsIndex? Index { get; init; }

		[JsonInclude]
		[JsonPropertyName("primaries")]
		public double? Primaries { get; init; }

		[JsonInclude]
		[JsonPropertyName("replication")]
		public double? Replication { get; init; }

		[JsonInclude]
		[JsonPropertyName("total")]
		public double? Total { get; init; }
	}

	public partial class ClusterIndicesShardsIndex
	{
		[JsonInclude]
		[JsonPropertyName("primaries")]
		public Elastic.Clients.Elasticsearch.Cluster.Stats.ClusterShardMetrics Primaries { get; init; }

		[JsonInclude]
		[JsonPropertyName("replication")]
		public Elastic.Clients.Elasticsearch.Cluster.Stats.ClusterShardMetrics Replication { get; init; }

		[JsonInclude]
		[JsonPropertyName("shards")]
		public Elastic.Clients.Elasticsearch.Cluster.Stats.ClusterShardMetrics Shards { get; init; }
	}

	public partial class ClusterIngest
	{
		[JsonInclude]
		[JsonPropertyName("number_of_pipelines")]
		public int NumberOfPipelines { get; init; }

		[JsonInclude]
		[JsonPropertyName("processor_stats")]
		public Dictionary<string, Elastic.Clients.Elasticsearch.Cluster.Stats.ClusterProcessor> ProcessorStats { get; init; }
	}

	public partial class ClusterJvm
	{
		[JsonInclude]
		[JsonPropertyName("max_uptime_in_millis")]
		public object MaxUptimeInMillis { get; init; }

		[JsonInclude]
		[JsonPropertyName("mem")]
		public Elastic.Clients.Elasticsearch.Cluster.Stats.ClusterJvmMemory Mem { get; init; }

		[JsonInclude]
		[JsonPropertyName("threads")]
		public object Threads { get; init; }

		[JsonInclude]
		[JsonPropertyName("versions")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Cluster.Stats.ClusterJvmVersion> Versions { get; init; }
	}

	public partial class ClusterJvmMemory
	{
		[JsonInclude]
		[JsonPropertyName("heap_max_in_bytes")]
		public object HeapMaxInBytes { get; init; }

		[JsonInclude]
		[JsonPropertyName("heap_used_in_bytes")]
		public object HeapUsedInBytes { get; init; }
	}

	public partial class ClusterJvmVersion
	{
		[JsonInclude]
		[JsonPropertyName("bundled_jdk")]
		public bool BundledJdk { get; init; }

		[JsonInclude]
		[JsonPropertyName("count")]
		public int Count { get; init; }

		[JsonInclude]
		[JsonPropertyName("using_bundled_jdk")]
		public bool UsingBundledJdk { get; init; }

		[JsonInclude]
		[JsonPropertyName("version")]
		public string Version { get; init; }

		[JsonInclude]
		[JsonPropertyName("vm_name")]
		public string VmName { get; init; }

		[JsonInclude]
		[JsonPropertyName("vm_vendor")]
		public string VmVendor { get; init; }

		[JsonInclude]
		[JsonPropertyName("vm_version")]
		public string VmVersion { get; init; }
	}

	public partial class ClusterNetworkTypes
	{
		[JsonInclude]
		[JsonPropertyName("http_types")]
		public Dictionary<string, int> HttpTypes { get; init; }

		[JsonInclude]
		[JsonPropertyName("transport_types")]
		public Dictionary<string, int> TransportTypes { get; init; }
	}

	public partial class ClusterNodeCount
	{
		[JsonInclude]
		[JsonPropertyName("coordinating_only")]
		public int CoordinatingOnly { get; init; }

		[JsonInclude]
		[JsonPropertyName("data")]
		public int Data { get; init; }

		[JsonInclude]
		[JsonPropertyName("ingest")]
		public int Ingest { get; init; }

		[JsonInclude]
		[JsonPropertyName("master")]
		public int Master { get; init; }

		[JsonInclude]
		[JsonPropertyName("total")]
		public int Total { get; init; }

		[JsonInclude]
		[JsonPropertyName("voting_only")]
		public int VotingOnly { get; init; }

		[JsonInclude]
		[JsonPropertyName("data_cold")]
		public int DataCold { get; init; }

		[JsonInclude]
		[JsonPropertyName("data_frozen")]
		public int? DataFrozen { get; init; }

		[JsonInclude]
		[JsonPropertyName("data_content")]
		public int DataContent { get; init; }

		[JsonInclude]
		[JsonPropertyName("data_warm")]
		public int DataWarm { get; init; }

		[JsonInclude]
		[JsonPropertyName("data_hot")]
		public int DataHot { get; init; }

		[JsonInclude]
		[JsonPropertyName("ml")]
		public int Ml { get; init; }

		[JsonInclude]
		[JsonPropertyName("remote_cluster_client")]
		public int RemoteClusterClient { get; init; }

		[JsonInclude]
		[JsonPropertyName("transform")]
		public int Transform { get; init; }
	}

	public partial class ClusterNodes
	{
		[JsonInclude]
		[JsonPropertyName("count")]
		public Elastic.Clients.Elasticsearch.Cluster.Stats.ClusterNodeCount Count { get; init; }

		[JsonInclude]
		[JsonPropertyName("discovery_types")]
		public Dictionary<string, int> DiscoveryTypes { get; init; }

		[JsonInclude]
		[JsonPropertyName("fs")]
		public Elastic.Clients.Elasticsearch.Cluster.Stats.ClusterFileSystem Fs { get; init; }

		[JsonInclude]
		[JsonPropertyName("ingest")]
		public Elastic.Clients.Elasticsearch.Cluster.Stats.ClusterIngest Ingest { get; init; }

		[JsonInclude]
		[JsonPropertyName("jvm")]
		public Elastic.Clients.Elasticsearch.Cluster.Stats.ClusterJvm Jvm { get; init; }

		[JsonInclude]
		[JsonPropertyName("network_types")]
		public Elastic.Clients.Elasticsearch.Cluster.Stats.ClusterNetworkTypes NetworkTypes { get; init; }

		[JsonInclude]
		[JsonPropertyName("os")]
		public Elastic.Clients.Elasticsearch.Cluster.Stats.ClusterOperatingSystem Os { get; init; }

		[JsonInclude]
		[JsonPropertyName("packaging_types")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Cluster.Stats.NodePackagingType> PackagingTypes { get; init; }

		[JsonInclude]
		[JsonPropertyName("plugins")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.PluginStats> Plugins { get; init; }

		[JsonInclude]
		[JsonPropertyName("process")]
		public Elastic.Clients.Elasticsearch.Cluster.Stats.ClusterProcess Process { get; init; }

		[JsonInclude]
		[JsonPropertyName("versions")]
		public IReadOnlyCollection<string> Versions { get; init; }
	}

	public partial class ClusterOperatingSystem
	{
		[JsonInclude]
		[JsonPropertyName("allocated_processors")]
		public int AllocatedProcessors { get; init; }

		[JsonInclude]
		[JsonPropertyName("available_processors")]
		public int AvailableProcessors { get; init; }

		[JsonInclude]
		[JsonPropertyName("mem")]
		public Elastic.Clients.Elasticsearch.Cluster.Stats.OperatingSystemMemoryInfo Mem { get; init; }

		[JsonInclude]
		[JsonPropertyName("names")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Cluster.Stats.ClusterOperatingSystemName> Names { get; init; }

		[JsonInclude]
		[JsonPropertyName("pretty_names")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Cluster.Stats.ClusterOperatingSystemPrettyName> PrettyNames { get; init; }

		[JsonInclude]
		[JsonPropertyName("architectures")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Cluster.Stats.ClusterOperatingSystemArchitecture>? Architectures { get; init; }
	}

	public partial class ClusterOperatingSystemArchitecture
	{
		[JsonInclude]
		[JsonPropertyName("count")]
		public int Count { get; init; }

		[JsonInclude]
		[JsonPropertyName("arch")]
		public string Arch { get; init; }
	}

	public partial class ClusterOperatingSystemName
	{
		[JsonInclude]
		[JsonPropertyName("count")]
		public int Count { get; init; }

		[JsonInclude]
		[JsonPropertyName("name")]
		public Elastic.Clients.Elasticsearch.Name Name { get; init; }
	}

	public partial class ClusterOperatingSystemPrettyName
	{
		[JsonInclude]
		[JsonPropertyName("count")]
		public int Count { get; init; }

		[JsonInclude]
		[JsonPropertyName("pretty_name")]
		public Elastic.Clients.Elasticsearch.Name PrettyName { get; init; }
	}

	public partial class ClusterProcess
	{
		[JsonInclude]
		[JsonPropertyName("cpu")]
		public Elastic.Clients.Elasticsearch.Cluster.Stats.ClusterProcessCpu Cpu { get; init; }

		[JsonInclude]
		[JsonPropertyName("open_file_descriptors")]
		public Elastic.Clients.Elasticsearch.Cluster.Stats.ClusterProcessOpenFileDescriptors OpenFileDescriptors { get; init; }
	}

	public partial class ClusterProcessCpu
	{
		[JsonInclude]
		[JsonPropertyName("percent")]
		public int Percent { get; init; }
	}

	public partial class ClusterProcessOpenFileDescriptors
	{
		[JsonInclude]
		[JsonPropertyName("avg")]
		public object Avg { get; init; }

		[JsonInclude]
		[JsonPropertyName("max")]
		public object Max { get; init; }

		[JsonInclude]
		[JsonPropertyName("min")]
		public object Min { get; init; }
	}

	public partial class ClusterProcessor
	{
		[JsonInclude]
		[JsonPropertyName("count")]
		public object Count { get; init; }

		[JsonInclude]
		[JsonPropertyName("current")]
		public object Current { get; init; }

		[JsonInclude]
		[JsonPropertyName("failed")]
		public object Failed { get; init; }

		[JsonInclude]
		[JsonPropertyName("time_in_millis")]
		public object TimeInMillis { get; init; }
	}

	public partial class ClusterShardMetrics
	{
		[JsonInclude]
		[JsonPropertyName("avg")]
		public double Avg { get; init; }

		[JsonInclude]
		[JsonPropertyName("max")]
		public double Max { get; init; }

		[JsonInclude]
		[JsonPropertyName("min")]
		public double Min { get; init; }
	}

	public partial class FieldTypes
	{
		[JsonInclude]
		[JsonPropertyName("name")]
		public Elastic.Clients.Elasticsearch.Name Name { get; init; }

		[JsonInclude]
		[JsonPropertyName("count")]
		public int Count { get; init; }

		[JsonInclude]
		[JsonPropertyName("index_count")]
		public int IndexCount { get; init; }

		[JsonInclude]
		[JsonPropertyName("script_count")]
		public int? ScriptCount { get; init; }
	}

	public partial class FieldTypesMappings
	{
		[JsonInclude]
		[JsonPropertyName("field_types")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Cluster.Stats.FieldTypes> FieldTypes { get; init; }

		[JsonInclude]
		[JsonPropertyName("runtime_field_types")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Cluster.Stats.RuntimeFieldTypes>? RuntimeFieldTypes { get; init; }
	}

	public partial class IndicesVersions
	{
		[JsonInclude]
		[JsonPropertyName("index_count")]
		public int IndexCount { get; init; }

		[JsonInclude]
		[JsonPropertyName("primary_shard_count")]
		public int PrimaryShardCount { get; init; }

		[JsonInclude]
		[JsonPropertyName("total_primary_bytes")]
		public object TotalPrimaryBytes { get; init; }

		[JsonInclude]
		[JsonPropertyName("version")]
		public string Version { get; init; }
	}

	public partial class NodePackagingType
	{
		[JsonInclude]
		[JsonPropertyName("count")]
		public int Count { get; init; }

		[JsonInclude]
		[JsonPropertyName("flavor")]
		public string Flavor { get; init; }

		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type { get; init; }
	}

	public partial class OperatingSystemMemoryInfo
	{
		[JsonInclude]
		[JsonPropertyName("free_in_bytes")]
		public object FreeInBytes { get; init; }

		[JsonInclude]
		[JsonPropertyName("free_percent")]
		public int FreePercent { get; init; }

		[JsonInclude]
		[JsonPropertyName("total_in_bytes")]
		public object TotalInBytes { get; init; }

		[JsonInclude]
		[JsonPropertyName("used_in_bytes")]
		public object UsedInBytes { get; init; }

		[JsonInclude]
		[JsonPropertyName("used_percent")]
		public int UsedPercent { get; init; }
	}

	public partial class RuntimeFieldTypes
	{
		[JsonInclude]
		[JsonPropertyName("name")]
		public Elastic.Clients.Elasticsearch.Name Name { get; init; }

		[JsonInclude]
		[JsonPropertyName("count")]
		public int Count { get; init; }

		[JsonInclude]
		[JsonPropertyName("index_count")]
		public int IndexCount { get; init; }

		[JsonInclude]
		[JsonPropertyName("scriptless_count")]
		public int ScriptlessCount { get; init; }

		[JsonInclude]
		[JsonPropertyName("shadowed_count")]
		public int ShadowedCount { get; init; }

		[JsonInclude]
		[JsonPropertyName("lang")]
		public IReadOnlyCollection<string> Lang { get; init; }

		[JsonInclude]
		[JsonPropertyName("lines_max")]
		public int LinesMax { get; init; }

		[JsonInclude]
		[JsonPropertyName("lines_total")]
		public int LinesTotal { get; init; }

		[JsonInclude]
		[JsonPropertyName("chars_max")]
		public int CharsMax { get; init; }

		[JsonInclude]
		[JsonPropertyName("chars_total")]
		public int CharsTotal { get; init; }

		[JsonInclude]
		[JsonPropertyName("source_max")]
		public int SourceMax { get; init; }

		[JsonInclude]
		[JsonPropertyName("source_total")]
		public int SourceTotal { get; init; }

		[JsonInclude]
		[JsonPropertyName("doc_max")]
		public int DocMax { get; init; }

		[JsonInclude]
		[JsonPropertyName("doc_total")]
		public int DocTotal { get; init; }
	}
}