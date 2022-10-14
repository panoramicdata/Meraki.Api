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
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }

	/// <summary>
	/// Username for PPPoE authentication.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "username")]
	public string? Username { get; set; }

	/// <summary>
	/// Password for pppoe authenticaion, this parameter is not returned
	/// </summary>
	[ApiAccess(ApiAccess.Update)]
	[DataMember(Name = "password")]
	public string? Password { get; set; }
}