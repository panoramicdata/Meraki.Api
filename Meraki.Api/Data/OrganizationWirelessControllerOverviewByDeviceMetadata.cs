namespace Meraki.Api.Data;

/// <summary>
/// Metadata relevant to the paginated dataset
/// </summary>
[DataContract]
public class OrganizationWirelessControllerOverviewByDeviceMetadata
{
	/// <summary>
	/// Counts relating to the paginated dataset
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "counts")]
	public OrganizationWirelessControllerOverviewByDeviceMetadataCounts Counts { get; set; } = new();
}
