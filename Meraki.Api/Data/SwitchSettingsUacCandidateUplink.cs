namespace Meraki.Api.Data;

/// <summary>
/// Undocumented
/// </summary>
[DataContract]
public class SwitchSettingsUacCandidateUplink
{
	/// <summary>
	/// Undocumented Enabled
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }
}