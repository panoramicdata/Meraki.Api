namespace Meraki.Api.Data;

/// <summary>
/// Rules
/// </summary>
[DataContract]
public class SsidLayer7FirewallRule
{
	/// <summary>
	/// 'Deny' traffic specified by this rule
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "policy")]
	public string Policy { get; set; } = string.Empty;

	/// <summary>
	/// Type of the L7 firewall rule. One of: 'application', 'applicationCategory', 'host', 'port', 'ipRange'
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "type")]
	public string Type { get; set; } = string.Empty;

	/// <summary>
	/// The value of what needs to get blocked. Format of the value varies depending on type of the firewall rule selected.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "value")]
	public Value Value { get; set; } = new();
}
