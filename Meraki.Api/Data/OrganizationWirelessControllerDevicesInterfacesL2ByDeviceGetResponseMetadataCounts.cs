namespace Meraki.Api.Data;

/// <summary>
/// Counts relating to the paginated dataset
/// </summary>
[DataContract]
public class OrganizationWirelessControllerDevicesInterfacesL2ByDeviceGetResponseMetadataCounts
{
	/// <summary>
	/// Counts relating to the paginated items
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public OrganizationWirelessControllerDevicesInterfacesL2ByDeviceGetResponseMetadataCountsItems Items { get; set; } = new();
}
