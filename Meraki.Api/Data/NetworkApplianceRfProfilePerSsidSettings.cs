namespace Meraki.Api.Data;

/// <summary>
/// NetworkApplianceRfProfiles
/// </summary>
[DataContract]
public class NetworkApplianceRfProfilePerSsidSettings
{
	/// <summary>
	/// Settings for SSID 1
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "1")]
	public NetworkApplianceRfProfilePerSsidSettingsSettings? Ssid1 { get; set; }

	/// <summary>
	/// Settings for SSID 2
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "2")]
	public NetworkApplianceRfProfilePerSsidSettingsSettings? Ssid2 { get; set; }

	/// <summary>
	/// Settings for SSID 3
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "3")]
	public NetworkApplianceRfProfilePerSsidSettingsSettings? Ssid3 { get; set; }

	/// <summary>
	/// Settings for SSID 4
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "4")]
	public NetworkApplianceRfProfilePerSsidSettingsSettings? Ssid4 { get; set; }
}
