namespace Meraki.Api.Data;

/// <summary>
/// Rule associated to an authorization policy set
/// </summary>
[DataContract]
public class OrganizationNacAuthorizationPolicySetRule
{
	/// <summary>
	/// Rank of the rule
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "rank")]
	public int Rank { get; set; }

	/// <summary>
	/// Name of a rule
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// ID of the rule
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ruleId")]
	public string RuleId { get; set; } = string.Empty;

	/// <summary>
	/// Enabled status of a rule
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }

	/// <summary>
	/// Authorization profile associated with the rule
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "authorizationProfile")]
	public OrganizationNacAuthorizationPolicySetRuleAuthorizationProfile AuthorizationProfile { get; set; } = new();

	/// <summary>
	/// Counts
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "counts")]
	public OrganizationNacAuthorizationPolicySetRuleCounts Counts { get; set; } = new();
}
