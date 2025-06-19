namespace Meraki.Api.Data;

/// <summary>
/// Network Wireless Radio AutoRf Update Request
/// </summary>
[DataContract]
public class NetworkWirelessRadioAutoRfUpdateRequest
{
	/// <summary>
	/// AI-RRM settings
	/// </summary>
	[DataMember(Name = "aiRrm")]
	public NetworkWirelessRadioAutoRfUpdateRequestAiRrm? AiRrm { get; set; }

	/// <summary>
	/// Busy Hour settings
	/// </summary>
	[DataMember(Name = "busyHour")]
	public NetworkWirelessRadioAutoRfUpdateRequestBusyHour? BusyHour { get; set; }

	/// <summary>
	/// Channel settings
	/// </summary>
	[DataMember(Name = "channel")]
	public NetworkWirelessRadioAutoRfUpdateRequestChannel? Channel { get; set; }

	/// <summary>
	/// FRA settings
	/// </summary>
	[DataMember(Name = "fra")]
	public NetworkWirelessRadioAutoRfUpdateRequestFra? Fra { get; set; }
}
