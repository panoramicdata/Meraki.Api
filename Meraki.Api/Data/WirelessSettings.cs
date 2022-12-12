namespace Meraki.Api.Data;

/// <summary>
/// Wireless settings
/// </summary>
[DataContract]
public class WirelessSettings
{
	/// <summary>
	/// Toggle for enabling or disabling meshing in a network
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "meshingEnabled")]
	public bool MeshingEnabled { get; set; }

	/// <summary>
	/// Toggle for enabling or disabling IPv6 bridging in a network (Note: if enabled, SSIDs must also be configured to use bridge mode)
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "ipv6BridgeEnabled")]
	public bool Ipv6BridgeEnabled { get; set; }

	/// <summary>
	/// Toggle for enabling or disabling location analytics for your network
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "locationAnalyticsEnabled")]
	public bool LocationAnalyticsEnabled { get; set; }

	/// <summary>
	/// Toggle for enabling or disabling LED lights on all APs in the network (making them run dark)
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "ledLightsOn")]
	public bool LedLightsOn { get; set; }

	/// <summary>
	/// Named Vlans
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "namedVlans")]
	public WirelessSettingsNamedVlans? NamedVlans { get; set; }

	/// <summary>
	/// The upgrade strategy to apply to the network. Must be one of 'minimizeUpgradeTime' or 'minimizeClientDowntime'. Requires firmware version MR 26.8 or higher'
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "upgradeStrategy")]
	public string UpgradeStrategy { get; set; } = "minimizeUpgradeTime";
}
