namespace Meraki.Api.Data;
/// <summary>
/// Uplink Wan Pppoe Authentication Settings for an MX Appliance
/// </summary>
[DataContract]

public class DeviceApplianceUplinkSettingsInterfacesWanPppoeAuthentication
{
	/// <summary>
	/// Whether PPPoE authentication is enabled.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }

	/// <summary>
	/// Username for PPPoE authentication.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "username")]
	public string? Username { get; set; }
}