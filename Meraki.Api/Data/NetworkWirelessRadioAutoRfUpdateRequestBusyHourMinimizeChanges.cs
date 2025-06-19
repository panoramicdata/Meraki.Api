namespace Meraki.Api.Data;

/// <summary>
/// Minimize Changes settings
/// </summary>
[DataContract]
public class NetworkWirelessRadioAutoRfUpdateRequestBusyHourMinimizeChanges
{
	/// <summary>
	/// Toggle for enabling or disabling Busy Hour in a network
	/// </summary>
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }
}