namespace Meraki.Api.Data;

/// <summary>
/// Metadata relevant to the paginated dataset
/// </summary>
[DataContract]
public class OrganizationsSaseConnectivityEnrollableNetworkResponseMetadata
{
	/// <summary>
	/// Counts relating to the paginated dataset
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "counts")]
	public OrganizationsSaseConnectivityEnrollableNetworkResponseMetadataCounts Counts { get; set; } = new();
}
