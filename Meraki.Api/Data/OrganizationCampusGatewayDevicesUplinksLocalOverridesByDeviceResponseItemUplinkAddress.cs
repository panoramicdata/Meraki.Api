namespace Meraki.Api.Data;

/// <summary>
/// Address of the interface
/// </summary>
[DataContract]
public class OrganizationCampusGatewayDevicesUplinksLocalOverridesByDeviceResponseItemUplinkAddress
{
	/// <summary>
	/// IP address of the interface
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "address")]
	public string Address { get; set; } = string.Empty;

	/// <summary>
	/// Assignment mode of the interface
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "assignmentMode")]
	public string AssignmentMode { get; set; } = string.Empty;

	/// <summary>
	/// Gateway of the interface
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "gateway")]
	public string Gateway { get; set; } = string.Empty;

	/// <summary>
	/// Protocol of the interface
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "protocol")]
	public string Protocol { get; set; } = string.Empty;

	/// <summary>
	/// Subnet mask of the interface
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "subnetMask")]
	public string SubnetMask { get; set; } = string.Empty;
}