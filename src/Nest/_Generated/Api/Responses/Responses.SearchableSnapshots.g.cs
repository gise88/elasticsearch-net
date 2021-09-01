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

using OneOf;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable restore
namespace Nest.SearchableSnapshots
{
	public partial class ClearCacheResponse : ResponseBase
	{
		[JsonPropertyName("stub")]
		public int Stub
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class MountResponse : ResponseBase
	{
		[JsonPropertyName("snapshot")]
		public Nest.SearchableSnapshots.Mount.MountedSnapshot Snapshot
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class StatsResponse : ResponseBase
	{
		[JsonPropertyName("stats")]
		public object Stats
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("total")]
		public object Total
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}
}