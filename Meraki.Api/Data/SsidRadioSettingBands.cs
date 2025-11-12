namespace Meraki.Api.Data;

/// <summary>
/// Ssid Radio Setting Bands
/// </summary>
[DataContract]
public class SsidRadioSettingBands
{
	/// <summary>
	/// SsidRadioSettingBands Bands
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "enabled")]
	public List<string>? Enabled { get; set; }
}
