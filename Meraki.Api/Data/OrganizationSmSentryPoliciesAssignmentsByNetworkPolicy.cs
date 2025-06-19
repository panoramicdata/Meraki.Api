namespace Meraki.Api.Data;

/// <summary>
/// Sentry Group Policy
/// </summary>
[DataContract]
public class OrganizationSmSentryPoliciesAssignmentsByNetworkPolicy
{
	/// <summary>
	/// The creation time of the Sentry Policy
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "createdAt")]
	public string CreatedAt { get; set; } = string.Empty;

	/// <summary>
	/// The number of the Group Policy
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "groupNumber")]
	public string GroupNumber { get; set; } = string.Empty;

	/// <summary>
	/// The Id of the Group Policy. This is associated with the network specified by the networkId.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "groupPolicyId")]
	public string GroupPolicyId { get; set; } = string.Empty;

	/// <summary>
	/// The last update time of the Sentry Policy
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "lastUpdatedAt")]
	public string LastUpdatedAt { get; set; } = string.Empty;

	/// <summary>
	/// The Id of the Network the Sentry Policy is associated with. In a locale, this should be the Wireless Group if present, otherwise the Wired Group.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "networkId")]
	public string NetworkId { get; set; } = string.Empty;

	/// <summary>
	/// The Id of the Sentry Policy
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "policyId")]
	public string PolicyId { get; set; } = string.Empty;

	/// <summary>
	/// The priority of the Sentry Policy
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "priority")]
	public string Priority { get; set; } = string.Empty;

	/// <summary>
	/// The scope of the Sentry Policy. enum = ["all", "none", "withAll", "withAny", "withoutAll", ...]
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "scope")]
	public string Scope { get; set; } = string.Empty;

	/// <summary>
	/// The Id of the Systems Manager Network the Sentry Policy is assigned to
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "smNetworkId")]
	public string SmNetworkId { get; set; } = string.Empty;

	/// <summary>
	/// The tags of the Sentry Policy
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "tags")]
	public List<string> Tags { get; set; } = [];
}