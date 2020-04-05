using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateDeviceCellularGatewaySettings
	/// </summary>
	[DataContract]
	public partial class UpdateDeviceCellularGatewaySettings
	{
		/// <summary>
		/// list of all reserved IP ranges for a single MG
		/// </summary>
		/// <value>list of all reserved IP ranges for a single MG</value>
		[DataMember(Name = "reservedIpRanges", EmitDefaultValue = false)]
		public List<ReservedIpRange> ReservedIpRanges { get; set; }
		/// <summary>
		/// list of all fixed IP assignments for a single MG
		/// </summary>
		/// <value>list of all fixed IP assignments for a single MG</value>
		[DataMember(Name = "fixedIpAssignments", EmitDefaultValue = false)]
		public List<FixedIpAssignment> FixedIpAssignments { get; set; }
	}
}
