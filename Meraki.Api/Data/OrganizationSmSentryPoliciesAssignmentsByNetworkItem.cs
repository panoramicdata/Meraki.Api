namespace Meraki.Api.Data;

/// <summary>
/// Sentry Group Policy for the Organization keyed by the Network or Locale Id the Policy belongs to
/// </summary>
[DataContract]
public class OrganizationSmSentryPoliciesAssignmentsByNetworkItem
{
	/// <summary>
	/// The Id of the Network
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "networkId")]
	public string NetworkId { get; set; } = string.Empty;

	/// <summary>
	/// Array of Sentry Group Policies for the Network
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "policies")]
	public List<OrganizationSmSentryPoliciesAssignmentsByNetworkPolicy> Policies { get; set; } = [];
}
