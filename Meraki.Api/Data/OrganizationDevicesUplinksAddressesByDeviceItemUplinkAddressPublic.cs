namespace Meraki.Api.Data;

/// <summary>
/// Public interface information.
/// </summary>
[DataContract]
public class OrganizationDevicesUplinksAddressesByDeviceItemUplinkAddressPublic
{
	/// <summary>
	/// The device uplink public IP address.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "address")]
	public string Address { get; set; } = string.Empty;
}