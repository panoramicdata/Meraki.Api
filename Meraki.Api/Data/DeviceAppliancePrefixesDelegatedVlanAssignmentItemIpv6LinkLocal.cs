namespace Meraki.Api.Data;

/// <summary>
/// Link Local
/// </summary>
[DataContract]
public class DeviceAppliancePrefixesDelegatedVlanAssignmentItemIpv6LinkLocal
{
	/// <summary>
	/// Address
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "address")]
	public string Address { get; set; } = string.Empty;
}