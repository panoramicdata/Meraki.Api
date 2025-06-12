namespace Meraki.Api.Data;

/// <summary>
/// Solicited Node Multicast
/// </summary>
[DataContract]
public class DeviceAppliancePrefixesDelegatedVlanAssignmentItemIpv6SolicitedNodeMulticast
{
	/// <summary>
	/// Address
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "address")]
	public string Address { get; set; } = string.Empty;
}