namespace Meraki.Api.Data;

/// <summary>
/// Organization Sm Sentry Policies Assignments By Network Response
/// </summary>
[DataContract]
public class OrganizationSmSentryPoliciesAssignmentsByNetworkResponse
{
	/// <summary>
	/// Metadata relevant to the paginated dataset
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "meta")]
	public OrganizationSmSentryPoliciesAssignmentsByNetworkResponseMetadata Meta { get; set; } = new();

	/// <summary>
	/// Sentry Group Policies for the Organization keyed by the Network or Locale Id the Policy belongs to
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "items")]
	public List<OrganizationSmSentryPoliciesAssignmentsByNetworkItem> Items { get; set; } = [];
}
