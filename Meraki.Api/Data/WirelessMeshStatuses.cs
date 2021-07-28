using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Mesh statuses
	/// </summary>
	[DataContract]
	public class WirelessMeshStatuses
	{
		/// <summary>
		/// Serial
		/// </summary>
		[DataMember(Name = "serial")]
		public string Serial { get; set; } = string.Empty;

		/// <summary>
		/// Mesh route
		/// </summary>
		[DataMember(Name = "meshRoute")]
		public List<string> MeshRoute { get; set; } = new();

		/// <summary>
		/// Latest mesh performance
		/// </summary>
		[DataMember(Name = "latestMeshPerformance")]
		public LatestMeshPerformance LatestMeshPerformance { get; set; } = new();
	}
}
