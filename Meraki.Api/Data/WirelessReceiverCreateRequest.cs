namespace Meraki.Api.Data;

/// <summary>
/// Wireless Receiver Create Request
/// </summary>
[DataContract]
public class WirelessReceiverCreateRequest
{
	/// <summary>
	/// Secret Value for Receiver
	/// </summary>
	[DataMember(Name = "sharedSecret")]
	public string SharedSecret { get; set; } = string.Empty;

	/// <summary>
	/// Receiver Url
	/// </summary>
	[DataMember(Name = "url")]
	public string Url { get; set; } = string.Empty;

	/// <summary>
	/// Scanning API Version
	/// </summary>
	[DataMember(Name = "version")]
	public string Version { get; set; } = string.Empty;

	/// <summary>
	/// Add scanning API receiver for network
	/// </summary>
	[DataMember(Name = "network")]
	public WirelessReceiverNetworkSimple Network { get; set; } = new();

	/// <summary>
	/// Add scanning API Radio
	/// </summary>
	[DataMember(Name = "radio")]
	public WirelessReceiverRadio Radio { get; set; } = new();
}
