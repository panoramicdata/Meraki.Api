namespace Meraki.Api.Data;

/// <summary>
/// Counts relating to the paginated dataset
/// </summary>
[DataContract]
public class OrganizationWirelessControllerDevicesRedundancyStatusesMetadataCounts
{
	/// <summary>
	/// Counts relating to the paginated items
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public OrganizationWirelessControllerDevicesRedundancyStatusesMetadataCountsItems Items { get; set; } = new();
}
