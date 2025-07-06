namespace Meraki.Api.Data;

/// <summary>
/// Counts relating to the paginated dataset
/// </summary>
[DataContract]
public class OrganizationsWirelessControllerClientsOverviewByDeviceMetadataCounts
{
	/// <summary>
	/// Counts relating to the paginated items
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public OrganizationsWirelessControllerClientsOverviewByDeviceMetadataCountsItems Items { get; set; } = new();
}
