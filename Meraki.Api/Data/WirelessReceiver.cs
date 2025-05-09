namespace Meraki.Api.Data;

/// <summary>
/// Scanning API receiver
/// </summary>
[DataContract]
public class WirelessReceiver
{
	/// <summary>
	/// Receiver ID
	/// </summary>
	[ApiKey]
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "receiverId")]
	public string ReceiverId { get; set; } = string.Empty;

	/// <summary>
	/// Receiver URL
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "url")]
	public string Url { get; set; } = string.Empty;

	/// <summary>
	/// Scanning API Version
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "version")]
	public string Version { get; set; } = string.Empty;

	/// <summary>
	/// Add scanning API receiver for network
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "network")]
	public WirelessReceiverNetwork Network { get; set; } = new();

	/// <summary>
	/// Add scanning API Radio
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "radio")]
	public WirelessReceiverRadio Radio { get; set; } = new();
}
