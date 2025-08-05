namespace Meraki.Api.Data;

/// <summary>
/// Connectivity information of a wireless LAN controller
/// </summary>
[DataContract]
public class OrganizationWirelessControllerAvailabilitiesChangeHistoryItemChange
{
	/// <summary>
	/// The end time(UTC seconds) of the wireless LAN controller connectivity status change. This attribute is set to be null by default if there's no need to assign.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "endTs")]
	public string EndTs { get; set; } = string.Empty;

	/// <summary>
	/// The start time(UTC seconds) of the wireless LAN controller connectivity status change
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "startTs")]
	public string StartTs { get; set; } = string.Empty;

	/// <summary>
	/// The wireless LAN controller connectivity status
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;
}