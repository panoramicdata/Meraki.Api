namespace Meraki.Api.Data;

/// <summary>
/// Uplink selection settings for switch
/// </summary>
[DataContract]
public class SwitchSettingsUplinkSelection
{
	/// <summary>
	/// Failback settings for uplink selection
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "failback")]
	public SwitchSettingsUplinkSelectionFailback? Failback { get; set; }

	/// <summary>
	/// Which uplinks to consider (all or primary-uplink-only)
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "candidates")]
	public string? Candidates { get; set; }
}
