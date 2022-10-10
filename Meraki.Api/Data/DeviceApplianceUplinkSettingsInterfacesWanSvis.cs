namespace Meraki.Api.Data;
/// <summary>
/// Uplink Wan Svis Settings for an MX Appliance
/// </summary>
[DataContract]

public class DeviceApplianceUplinkSettingsInterfacesWanSvis
{
	/// <summary>
	/// IPv4 settings for static/dynamic mode.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "ipv4")]
	public DeviceApplianceUplinkSettingsInterfacesWanSvisIpvx? Ipv4 { get; set; }

	/// <summary>
	/// IPv6 settings for static/dynamic mode.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "ipv6")]
	public DeviceApplianceUplinkSettingsInterfacesWanSvisIpvx? Ipv6 { get; set; }
}