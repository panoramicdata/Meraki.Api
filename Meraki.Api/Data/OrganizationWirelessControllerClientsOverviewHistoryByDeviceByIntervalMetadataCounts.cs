namespace Meraki.Api.Data;

/// <summary>
/// 
/// </summary>
[DataContract]
public class OrganizationWirelessControllerClientsOverviewHistoryByDeviceByIntervalMetadataCounts
{
	/// <summary>
	/// Counts relating to the paginated items
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public OrganizationWirelessControllerClientsOverviewHistoryByDeviceByIntervalMetadataCountsItems Items { get; set; } = new();
}
