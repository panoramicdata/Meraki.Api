namespace Meraki.Api.Data;

/// <summary>
/// Wireless LAN controller connectivity information entry
/// </summary>
[DataContract]
public class OrganizationWirelessControllerAvailabilitiesChangeHistoryItem
{
	/// <summary>
	/// Wireless LAN controller cloud ID
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// Connectivity information of a wireless LAN controller
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "changes")]
	public List<OrganizationWirelessControllerAvailabilitiesChangeHistoryItemChange> Changes { get; set; } = [];
}
