namespace Meraki.Api.Data;

/// <summary>
/// Organization Wireless Controller Availabilities Change History
/// </summary>
public class OrganizationWirelessControllerAvailabilitiesChangeHistory
{
	/// <summary>
	/// Metadata relevant to the paginated dataset
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "meta")]
	public OrganizationWirelessControllerAvailabilitiesChangeHistoryMetadata Meta { get; set; } = new();

	/// <summary>
	/// Wireless LAN controller connectivity information
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public List<OrganizationWirelessControllerAvailabilitiesChangeHistoryItem> Items { get; set; } = [];
}
