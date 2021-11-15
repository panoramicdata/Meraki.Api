namespace Meraki.Api.Data;

/// <summary>
/// UpdateNetworkL7FirewallRules
/// </summary>
[DataContract]
public class Layer7FirewallRules
{
	/// <summary>
	/// An ordered array of the MX L7 firewall rules
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "rules")]
	public List<Layer7FirewallRule> Rules { get; set; } = null!;
}
