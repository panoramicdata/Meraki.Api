namespace Meraki.Api.Data;

/// <summary>
/// Device Appliance Prefixes Delegated Vlan Assignment Item
/// </summary>
[DataContract]
public class DeviceAppliancePrefixesDelegatedVlanAssignmentItem
{
	/// <summary>
	/// Vlan
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "vlan")]
	public DeviceAppliancePrefixesDelegatedVlanAssignmentItemVlan Vlan { get; set; } = new();

	/// <summary>
	/// Origin
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "origin")]
	public DeviceAppliancePrefixesDelegatedVlanAssignmentItemOrigin Origin { get; set; } = new();

	/// <summary>
	/// Status
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;

	/// <summary>
	/// Ipv6
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ipv6")]
	public DeviceAppliancePrefixesDelegatedVlanAssignmentItemIpv6 Ipv6 { get; set; } = new();

}
