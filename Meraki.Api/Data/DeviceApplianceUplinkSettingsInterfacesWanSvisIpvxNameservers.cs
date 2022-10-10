namespace Meraki.Api.Data;
/// <summary>
/// Uplink Wan Svis Settings for an MX Appliance
/// </summary>
[DataContract]

public class DeviceApplianceUplinkSettingsInterfacesWanSvisIpvxNameservers
{
	/// <summary>
	/// Up to 2 nameserver addresses to use, ordered in priority from highest to lowest priority.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "addresses")]
	public List<string>? Addresses { get; set; }
}