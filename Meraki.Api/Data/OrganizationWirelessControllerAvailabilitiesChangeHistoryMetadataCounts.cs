namespace Meraki.Api.Data;

/// <summary>
/// Counts relating to the paginated dataset
/// </summary>
[DataContract]
public class OrganizationWirelessControllerAvailabilitiesChangeHistoryMetadataCounts
{
	/// <summary>
	/// Counts relating to the paginated items
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public OrganizationWirelessControllerAvailabilitiesChangeHistoryMetadataCountsItems Items { get; set; } = new();
}
