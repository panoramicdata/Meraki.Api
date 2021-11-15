namespace Meraki.Api.Data;

/// <summary>
/// The Bonjour settings for your group policy. Only valid if your network has a wireless configuration.
/// </summary>
[DataContract]
public class BonjourForwarding
{
	/// <summary>
	/// Gets or Sets Settings
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "settings")]
	public Setting Settings { get; set; }

	/// <summary>
	/// A list of the Bonjour forwarding rules for your group policy. If 'settings' is set to 'custom', at least one rule must be specified.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "rules")]
	public List<BonjourForwardingRule> Rules { get; set; } = new();
}
