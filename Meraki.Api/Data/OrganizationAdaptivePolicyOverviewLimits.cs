namespace Meraki.Api.Data;

/// <summary>
/// The current limits of various adaptive policy objects
/// </summary>
[DataContract]
public class OrganizationAdaptivePolicyOverviewLimits
{
	/// <summary>
	/// Maximum number of user-created adaptive policy groups allowed in the organization
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "customGroups")]
	public int? CustomGroups { get; set; }

	/// <summary>
	/// Maximum number of rules allowed in an adaptive policy ACL
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "rulesInAnAcl")]
	public int? RulesInAnAcl { get; set; }

	/// <summary>
	/// Maximum number of ACLs allowed in an adaptive policy
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "aclsInAPolicy")]
	public int? AclsInAPolicy { get; set; }

	/// <summary>
	/// Maximum number of policy objects (with the adaptive policy type) allowed in the organization
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "policyObjects")]
	public int? PolicyObjects { get; set; }
}
