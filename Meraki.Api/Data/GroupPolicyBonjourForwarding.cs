namespace Meraki.Api.Data;

/// <summary>
/// The Bonjour settings for your group policy. Only valid if your network has a wireless configuration.
/// </summary>
[DataContract]
public class GroupPolicyBonjourForwarding
{
	/// <summary>
	/// How Bonjour rules are applied. Can be 'network default', 'ignore' or 'custom'.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "settings")]
	public Setting Settings { get; set; }

	/// <summary>
	/// A list of the Bonjour forwarding rules for your group policy. If 'settings' is set to 'custom', at least one rule must be specified.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "rules")]
	public List<BonjourForwardingRule> Rules { get; set; } = [];
}
