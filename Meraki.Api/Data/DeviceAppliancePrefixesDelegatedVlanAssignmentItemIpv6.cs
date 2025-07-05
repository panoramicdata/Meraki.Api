namespace Meraki.Api.Data;

/// <summary>
/// Ipv6
/// </summary>
[DataContract]
public class DeviceAppliancePrefixesDelegatedVlanAssignmentItemIpv6
{
	/// <summary>
	/// Prefix
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "prefix")]
	public string Prefix { get; set; } = string.Empty;

	/// <summary>
	/// Address
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "address")]
	public string Address { get; set; } = string.Empty;

	/// <summary>
	/// Link Local
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "linkLocal")]
	public DeviceAppliancePrefixesDelegatedVlanAssignmentItemIpv6LinkLocal LinkLocal { get; set; } = new();

	/// <summary>
	/// Solicited Node Multicast
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "solicitedNodeMulticast")]
	public DeviceAppliancePrefixesDelegatedVlanAssignmentItemIpv6SolicitedNodeMulticast SolicitedNodeMulticast { get; set; } = new();
}
