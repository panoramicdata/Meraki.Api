namespace Meraki.Api.Data;

/// <summary>
/// Undocumented uacAutomaticFailback
/// </summary>
[DataContract]
public class SwitchSettingsUacAutomaticFailback
{
	/// <summary>
	/// Undocumented
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }
}