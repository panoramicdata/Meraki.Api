namespace Meraki.Api.Data;

/// <summary>
/// Channel settings
/// </summary>
[DataContract]
public class NetworkWirelessRadioAutoRfUpdateRequestChannel
{
	/// <summary>
	/// Avoidance settings
	/// </summary>
	[DataMember(Name = "avoidance")]
	public NetworkWirelessRadioAutoRfUpdateRequestChannelAvoidance? Avoidance { get; set; }
}
