namespace Meraki.Api.Data;


/// <summary>
/// Network Wireless Radio Auto RF Update Response
/// </summary>
[DataContract]
public class NetworkWirelessRadioAutoRfUpdateResponse
{
	/// <summary>
	/// Name of the network
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Id of the network
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "networkId")]
	public string NetworkId { get; set; } = string.Empty;

	/// <summary>
	/// Time zone of the network
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "timeZone")]
	public string TimeZone { get; set; } = string.Empty;

	/// <summary>
	/// AI-RRM settings
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "aiRrm")]
	public NetworkWirelessRadioAutoRfUpdateResponseAiRrm AiRrm { get; set; } = new();

	/// <summary>
	/// Busy Hour settings
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "busyHour")]
	public NetworkWirelessRadioAutoRfUpdateResponseBusyHour BusyHour { get; set; } = new();

	/// <summary>
	/// Channel settings
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "channel")]
	public NetworkWirelessRadioAutoRfUpdateResponseChannel Channel { get; set; } = new();

	/// <summary>
	/// FRA settings
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "fra")]
	public NetworkWirelessRadioAutoRfUpdateResponseFra Fra { get; set; } = new();
}
