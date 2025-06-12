namespace Meraki.Api.Data;

/// <summary>
/// Automatic Busy Hour settings
/// </summary>
[DataContract]
public class NetworkWirelessRadioAutoRfUpdateResponseBusyHourScheduleAutomatic
{
	/// <summary>
	/// The hour that Automatic Busy Hour ends each day, in the network time zone
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "end")]
	public string End { get; set; } = string.Empty;

	/// <summary>
	/// The hour that Automatic Busy Hour starts each day, in the network time zone
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "start")]
	public string Start { get; set; } = string.Empty;
}