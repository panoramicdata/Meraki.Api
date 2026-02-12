namespace Meraki.Api.Data;

/// <summary>
/// Ssid Radio Setting
/// </summary>
[DataContract]
public class SsidRadioSetting
{
	/// <summary>
	/// Gets or Sets BandOperationName
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets BandOperationMode
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "bandOperationMode")]
	public BandOperationMode BandOperationMode { get; set; }

	/// <summary>
	/// Steers client to most open band. Can be either true or false. Defaults to true.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "bandSteeringEnabled")]
	public bool BandSteeringEnabled { get; set; }

	/// <summary>
	/// Sets min bitrate (Mbps) of this SSID. Can be one of '1', '2', '5.5', '6', '9', '11', '12', '18', '24', '36', '48' or '54'.
	/// </summary>
	/// THIS SHOULD NOT BE CONVERTED TO AN ENUM AS DESERIALIZATION OF 5.5 AS A NUMBER WILL NOT WORK. THEY ARE PROVIDED AS NUMBERS, NOT STRINGS, BY THE MERAKI API.
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "minBitrate")]
	public double MinBitrate { get; set; }

	/// <summary>
	/// SsidRadioSetting Bands
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "bands")]
	public SsidRadioSettingBands? Bands { get; set; }
}
