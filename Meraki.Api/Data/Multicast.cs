namespace Meraki.Api.Data;

/// <summary>
/// UpdateNetworkSwitchSettingsMulticast
/// </summary>
[DataContract]
public class Multicast
{
	/// <summary>
	/// Default multicast setting for entire network. IGMP snooping and Flood unknown multicast traffic settings are enabled by default.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "defaultSettings")]
	public DefaultSettings DefaultSettings { get; set; } = new();

	/// <summary>
	/// Array of paired switches/stacks/profiles and corresponding multicast settings. An empty array will clear the multicast settings.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "overrides")]
	public List<Override> Overrides { get; set; } = [];
}
