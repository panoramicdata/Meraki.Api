namespace Meraki.Api.Data;

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