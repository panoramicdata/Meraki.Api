namespace Meraki.Api.Data;

/// <summary>
/// UpdateNetworkSsidL3FirewallRules
/// </summary>
[DataContract]
public class SsidLayer3FirewallRules
{
	/// <summary>
	/// An ordered array of the firewall rules for this SSID (not including the local LAN access rule or the default rule)
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "rules")]
	public List<SsidLayer3FirewallRule> Rules { get; set; } = null!;

	/// <summary>
	/// Allow wireless client access to local LAN (boolean value - true allows access and false denies access) (optional)
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "allowLanAccess")]
	public bool? AllowLanAccess { get; set; }
}
