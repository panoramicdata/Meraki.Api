namespace Meraki.Api.Data;

/// <summary>
/// Manual Busy Hour settings
/// </summary>
[DataContract]
public class NetworkWirelessRadioAutoRfUpdateRequestBusyHourScheduleManual
{
	/// <summary>
	/// The hour that Manual Busy Hour ends each day, in the network time zone
	/// </summary>
	[DataMember(Name = "end")]
	public string? End { get; set; }

	/// <summary>
	/// The hour that Manual Busy Hour starts each day, in the network time zone
	/// </summary>
	[DataMember(Name = "start")]
	public string? Start { get; set; }
}