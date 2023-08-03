namespace Meraki.Api.Data;

/// <summary>
/// NetworkApplianceRfProfilePerSsidSettingsSettings
/// </summary>
[DataContract]
public class NetworkApplianceRfProfilePerSsidSettingsSettings
{
	/// <summary>
	/// Band mode of this SSID
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "bandOperationMode")]
	public string? BandOperationMode { get; set; }

	/// <summary>
	/// Whether this SSID steers clients to the most open band between 2.4 GHz and 5 GHz.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "bandSteeringEnabled")]
	public bool? BandSteeringEnabled { get; set; }
}
