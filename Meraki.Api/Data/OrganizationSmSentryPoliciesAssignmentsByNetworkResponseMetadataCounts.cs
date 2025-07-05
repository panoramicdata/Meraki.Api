namespace Meraki.Api.Data;

/// <summary>
/// Counts relating to the paginated dataset
/// </summary>
[DataContract]
public class OrganizationSmSentryPoliciesAssignmentsByNetworkResponseMetadataCounts
{
	/// <summary>
	/// Counts relating to the paginated items
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public OrganizationSmSentryPoliciesAssignmentsByNetworkResponseMetadataCountsItems Items { get; set; } = new();
}
