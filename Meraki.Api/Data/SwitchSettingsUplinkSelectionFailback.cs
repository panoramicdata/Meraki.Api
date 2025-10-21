namespace Meraki.Api.Data;

/// <summary>
/// Failback settings for uplink selection
/// </summary>
[DataContract]
public class SwitchSettingsUplinkSelectionFailback
{
	/// <summary>
	/// Whether failback is enabled
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }
}
