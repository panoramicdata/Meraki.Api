namespace Meraki.Api.Data;

/// <summary>
/// Organization Nac Authorization Policy Set
/// </summary>
[DataContract]
public class OrganizationNacAuthorizationPolicySet
{
	/// <summary>
	/// Rank of an authorization policy set
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "rank")]
	public int Rank { get; set; }

	/// <summary>
	/// Name of the authorization policy set
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// ID of the authorization policy set.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "policysetId")]
	public string PolicysetId { get; set; } = string.Empty;

	/// <summary>
	/// Current version of the authorization policy set
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "version")]
	public string Version { get; set; } = string.Empty;

	/// <summary>
	/// Enabled/Disabled status for an authorization policy set
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }

	/// <summary>
	/// True if any of the condition contains invalid/outdated attribute values
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "hasOutdatedCondition")]
	public bool HasOutdatedCondition { get; set; }

	/// <summary>
	/// Condition of Authorization rule.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "condition")]
	public object Condition { get; set; } = new();

	/// <summary>
	/// Summary of the conditions of rules
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "conditionTags")]
	public List<string> ConditionTags { get; set; } = [];

	/// <summary>
	/// Counts
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "counts")]
	public OrganizationNacAuthorizationPolicySetCounts Counts { get; set; } = new();

	/// <summary>
	/// Rules associated to an authorization policy set
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "rules")]
	public List<OrganizationNacAuthorizationPolicySetRule> Rules { get; set; } = [];
}
