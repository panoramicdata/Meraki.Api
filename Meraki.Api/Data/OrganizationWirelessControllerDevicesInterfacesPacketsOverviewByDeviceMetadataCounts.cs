namespace Meraki.Api.Data;

/// <summary>
/// Counts relating to the paginated dataset
/// </summary>
[DataContract]
public class OrganizationWirelessControllerDevicesInterfacesPacketsOverviewByDeviceMetadataCounts
{
	/// <summary>
	/// Counts relating to the paginated items
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public OrganizationWirelessControllerDevicesInterfacesPacketsOverviewByDeviceMetadataCountsItems Items { get; set; } = new();
}
