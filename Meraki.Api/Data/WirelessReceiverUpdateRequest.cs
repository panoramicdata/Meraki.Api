namespace Meraki.Api.Data;

/// <summary>
/// Wireless Receiver Update Request
/// </summary>
[DataContract]
public class WirelessReceiverUpdateRequest
{
	/// <summary>
	/// Receiver Url
	/// </summary>
	[DataMember(Name = "url")]
	public string? Url { get; set; }

	/// <summary>
	/// Scanning API Version
	/// </summary>
	[DataMember(Name = "version")]
	public string? Version { get; set; }

	/// <summary>
	/// Add scanning API Radio
	/// </summary>
	[DataMember(Name = "radio")]
	public WirelessReceiverRadio? Radio { get; set; }
}
