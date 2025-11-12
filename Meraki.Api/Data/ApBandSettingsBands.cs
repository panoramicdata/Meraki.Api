namespace Meraki.Api.Data;

/// <summary>
/// Ap Band Settings Bands
/// </summary>
[DataContract]
public class ApBandSettingsBands
{
	/// <summary>
	/// ApBandSettings Bands
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "enabled")]
	public List<string>? Enabled { get; set; }
}
