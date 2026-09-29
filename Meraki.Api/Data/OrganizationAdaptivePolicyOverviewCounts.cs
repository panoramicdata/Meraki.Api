namespace Meraki.Api.Data;

/// <summary>
/// Organization Adaptive Policy Overview Counts
/// </summary>
[DataContract]
public class OrganizationAdaptivePolicyOverviewCounts
{
	/// <summary>
	/// Groups
	/// </summary>
	[DataMember(Name = "groups")]
	public int Groups { get; set; }

	/// <summary>
	/// Custom ACLs
	/// </summary>
	[DataMember(Name = "customAcls")]
	public int CustomAcls { get; set; }

	/// <summary>
	/// Policies
	/// </summary>
	[DataMember(Name = "policies")]
	public int Policies { get; set; }

	/// <summary>
	/// Deny policies
	/// </summary>
	[DataMember(Name = "denyPolicies")]
	public int DenyPolicies { get; set; }

	/// <summary>
	/// Allow policies
	/// </summary>
	[DataMember(Name = "allowPolicies")]
	public int AllowPolicies { get; set; }

	/// <summary>
	/// Number of user-created adaptive policy groups currently in the organization
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "customGroups")]
	public int? CustomGroups { get; set; }

	/// <summary>
	/// Number of policy objects (with the adaptive policy type) currently in the organization
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "policyObjects")]
	public int? PolicyObjects { get; set; }
}
