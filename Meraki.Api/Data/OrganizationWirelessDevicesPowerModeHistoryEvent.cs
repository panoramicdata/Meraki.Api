namespace Meraki.Api.Data;

/// <summary>
/// Event indicating power mode changes for the device
/// </summary>
[DataContract]
public class OrganizationWirelessDevicesPowerModeHistoryEvent
{
	/// <summary>
	/// The power mode of the device
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "powerMode")]
	public string PowerMode { get; set; } = string.Empty;

	/// <summary>
	/// Timestamp of the event
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ts")]
	public string Ts { get; set; } = string.Empty;
}