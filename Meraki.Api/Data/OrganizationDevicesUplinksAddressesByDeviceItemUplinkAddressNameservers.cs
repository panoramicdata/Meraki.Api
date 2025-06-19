namespace Meraki.Api.Data;

/// <summary>
/// Device DNS nameserver information.
/// </summary>
[DataContract]
public class OrganizationDevicesUplinksAddressesByDeviceItemUplinkAddressNameservers
{
	/// <summary>
	/// Device DNS nameserver address.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "addresses")]
	public List<string> Addresses { get; set; } = [];
}