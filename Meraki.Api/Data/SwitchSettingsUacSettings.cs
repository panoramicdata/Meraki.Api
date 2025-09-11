namespace Meraki.Api.Data;

/// <summary>
/// Undocumented
/// </summary>
[DataContract]
public class SwitchSettingsUacSettings
{
	/// <summary>
	/// Undocumented
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "uacAutomaticFailbackEnabled")]
	public bool? UacAutomaticFailbackEnabled { get; set; }

	/// <summary>
	/// Undocumented
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "uacCandidateUplinkEnabled")]
	public bool? UacCandidateUplinkEnabled { get; set; }
}
