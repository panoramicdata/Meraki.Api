namespace Meraki.Api.Data;

/// <summary>
/// Source address and port configuration for the rule
/// </summary>
[DataContract]
public class LiveToolsAclHitCountGetResponseAclSource
{
	/// <summary>
	/// Source IP address for the rule, or "any"
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "address")]
	public string Address { get; set; } = string.Empty;

	/// <summary>
	/// Source port configuration for the rule.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "port")]
	public LiveToolsAclHitCountGetResponseAclSourcePort Port { get; set; } = new();
}
