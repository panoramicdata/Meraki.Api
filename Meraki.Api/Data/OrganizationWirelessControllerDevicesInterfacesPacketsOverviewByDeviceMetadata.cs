namespace Meraki.Api.Data;

/// <summary>
/// Metadata relevant to the paginated dataset
/// </summary>
[DataContract]
public class OrganizationWirelessControllerDevicesInterfacesPacketsOverviewByDeviceMetadata
{
	/// <summary>
	/// Counts relating to the paginated dataset
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "counts")]
	public OrganizationWirelessControllerDevicesInterfacesPacketsOverviewByDeviceMetadataCounts Counts { get; set; } = new();
}
