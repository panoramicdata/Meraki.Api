namespace Meraki.Api.Data;

/// <summary>
/// UpdateDeviceCellularGatewaySettings
/// </summary>
[DataContract]
public class CellularGatewaySettings
{
	/// <summary>
	/// list of all reserved IP ranges for a single MG
	/// </summary>
	/// <value>list of all reserved IP ranges for a single MG</value>
	[DataMember(Name = "reservedIpRanges")]
	public List<ReservedIpRange> ReservedIpRanges { get; set; } = new();
	/// <summary>
	/// list of all fixed IP assignments for a single MG
	/// </summary>
	/// <value>list of all fixed IP assignments for a single MG</value>
	[DataMember(Name = "fixedIpAssignments")]
	public List<FixedIpAssignment> FixedIpAssignments { get; set; } = new();
}
