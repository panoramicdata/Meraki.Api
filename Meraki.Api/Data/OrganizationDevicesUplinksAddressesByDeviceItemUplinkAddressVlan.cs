namespace Meraki.Api.Data;

/// <summary>
/// VLAN information of the uplink interface
/// </summary>
[DataContract]
public class OrganizationDevicesUplinksAddressesByDeviceItemUplinkAddressVlan
{
	/// <summary>
	/// VLAN ID of the uplink interface
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;
}