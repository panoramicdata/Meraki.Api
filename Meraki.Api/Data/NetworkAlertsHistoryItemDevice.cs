namespace Meraki.Api.Data;

/// <summary>
/// info related to the device that caused the alert
/// </summary>
[DataContract]
public class NetworkAlertsHistoryItemDevice
{
	/// <summary>
	/// device serial
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;
}