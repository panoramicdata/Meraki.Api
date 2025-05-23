namespace Meraki.Api.Data;

/// <summary>
/// Metadata relevant to the paginated dataset
/// </summary>
[DataContract]
public class OrganizationWirelessDevicesWirelessControllersByDeviceMetadata
{
	/// <summary>
	/// Counts relating to the paginated dataset
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "counts")]
	public OrganizationWirelessDevicesWirelessControllersByDeviceMetadataCounts Counts { get; set; } = new();
}
