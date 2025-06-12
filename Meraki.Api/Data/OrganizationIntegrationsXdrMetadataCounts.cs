namespace Meraki.Api.Data;

/// <summary>
/// Counts relating to the paginated dataset
/// </summary>
[DataContract]
public class OrganizationIntegrationsXdrMetadataCounts
{
	/// <summary>
	/// Counts relating to the paginated networks
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public OrganizationIntegrationsXdrMetadataCountsItems Items { get; set; } = new();
}
