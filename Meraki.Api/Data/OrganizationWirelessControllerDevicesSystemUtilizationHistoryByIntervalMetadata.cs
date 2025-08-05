namespace Meraki.Api.Data;

/// <summary>
/// Metadata relevant to the paginated dataset
/// </summary>
[DataContract]
public class OrganizationWirelessControllerDevicesSystemUtilizationHistoryByIntervalMetadata
{
	/// <summary>
	/// Counts relating to the paginated dataset
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "counts")]
	public OrganizationWirelessControllerDevicesSystemUtilizationHistoryByIntervalMetadataCounts Counts { get; set; } = new();
}
