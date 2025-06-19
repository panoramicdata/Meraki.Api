namespace Meraki.Api.Data;

/// <summary>
/// Destination address and port configuration for the rule
/// </summary>
[DataContract]
public class LiveToolsAclHitCountGetResponseAclDestination
{
	/// <summary>
	/// Destination IP address for the rule, or "any"
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "address")]
	public string Address { get; set; } = string.Empty;

	/// <summary>
	/// Destination port configuration for the rule.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "port")]
	public List<LiveToolsAclHitCountGetResponseAclDestinationPortItem> Port { get; set; } = [];
}
