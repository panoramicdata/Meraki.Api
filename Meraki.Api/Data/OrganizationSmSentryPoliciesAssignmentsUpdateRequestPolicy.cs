namespace Meraki.Api.Data;

/// <summary>
/// Sentry Group Policy for the Organization
/// </summary>
[DataContract]
public class OrganizationSmSentryPoliciesAssignmentsUpdateRequestPolicy
{
	/// <summary>
	/// The Group Policy Id
	/// </summary>
	[DataMember(Name = "groupPolicyId")]
	public string GroupPolicyId { get; set; } = string.Empty;

	/// <summary>
	/// The Sentry Policy Id, if updating an existing Sentry Policy
	/// </summary>
	[DataMember(Name = "policyId")]
	public string PolicyId { get; set; } = string.Empty;

	/// <summary>
	/// The scope of the Sentry Policy. enum = ["all", "none", "withAll", "withAny", "withoutAll", ...]
	/// </summary>
	[DataMember(Name = "scope")]
	public string Scope { get; set; } = string.Empty;

	/// <summary>
	/// The Id of the Systems Manager Network
	/// </summary>
	[DataMember(Name = "smNetworkId")]
	public string SmNetworkId { get; set; } = string.Empty;

	/// <summary>
	/// The tags for the Sentry Policy
	/// </summary>
	[DataMember(Name = "tags")]
	public List<string> Tags { get; set; } = [];
}