namespace Meraki.Api.Data;

/// <summary>
/// UpdateDeviceCellularGatewaySettings
/// </summary>
[DataContract]
public class CellularGatewayLanUpdateRequest
{
	/// <summary>
	/// list of all reserved IP ranges for a single MG
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "reservedIpRanges")]
	public List<ReservedIpRange> ReservedIpRanges { get; set; } = [];

	/// <summary>
	/// list of all fixed IP assignments for a single MG
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "fixedIpAssignments")]
	public List<FixedIpAssignment> FixedIpAssignments { get; set; } = [];
}
