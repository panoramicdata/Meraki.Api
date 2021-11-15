using Meraki.Api.Attributes;
using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// L7FirewallRule
/// </summary>
[DataContract]
public class Layer7FirewallRule
{
	/// <summary>
	/// Gets or Sets Policy
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "policy")]
	public Layer7FirewallRulePolicy Policy { get; set; }

	/// <summary>
	/// Gets or Sets Type
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "type")]
	public Layer7FirewallRuleType Type { get; set; }

	/// <summary>
	/// The 'value' of what you want to block.If 'type' is 'host', 'port' or 'ipRange', 'value' must be a string matching either a hostname (e.g.somewhere.com), a port (e.g. 8080), or an IP range(e.g. 192.1.0.0/16). If 'type' is 'application' or 'applicationCategory', then 'value' must be an object with an ID for the application.
	/// </summary>
	// The Object type will be different depending on the value of Type
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "value")]
	public object? Value { get; set; }
}
