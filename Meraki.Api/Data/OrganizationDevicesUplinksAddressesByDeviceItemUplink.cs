namespace Meraki.Api.Data;

/// <summary>
/// List of device uplink addresses information.
/// </summary>
[DataContract]
public class OrganizationDevicesUplinksAddressesByDeviceItemUplink
{
	/// <summary>
	/// Interface for the device uplink. Available options are: cellular, man1, man2, wan1, wan2
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "interface")]
	public UplinkInterface Interface { get; set; }

	/// <summary>
	/// List of device uplink addresses information.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "addresses")]
	public List<OrganizationDevicesUplinksAddressesByDeviceItemUplinkAddress> Addresses { get; set; } = [];
}
