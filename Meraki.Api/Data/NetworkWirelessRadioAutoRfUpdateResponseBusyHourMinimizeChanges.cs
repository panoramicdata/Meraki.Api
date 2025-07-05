namespace Meraki.Api.Data;

/// <summary>
/// Minimize Changes settings
/// </summary>
[DataContract]
public class NetworkWirelessRadioAutoRfUpdateResponseBusyHourMinimizeChanges
{
	/// <summary>
	/// Toggle for enabling or disabling Busy Hour in a network
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }
}