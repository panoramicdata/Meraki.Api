namespace Meraki.Api.Data;

/// <summary>
/// Avoidance settings
/// </summary>
[DataContract]
public class NetworkWirelessRadioAutoRfUpdateRequestChannelAvoidance
{
	/// <summary>
	/// Toggle for enabling or disabling channel avoidance in a network
	/// </summary>
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }
}