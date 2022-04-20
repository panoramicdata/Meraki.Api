namespace Meraki.Api.Data;

/// <summary>
/// Event data
/// </summary>
[DataContract]
public class EventData
{
	/// <summary>
	/// Radio
	/// </summary>
	[DataMember(Name = "radio")]
	public string? Radio { get; set; }

	/// <summary>
	/// VAP
	/// </summary>
	[DataMember(Name = "vap")]
	public string? Vap { get; set; }

	/// <summary>
	/// Client mac
	/// </summary>
	[DataMember(Name = "clientMac")]
	public string? ClientMac { get; set; }

	/// <summary>
	/// Client ip
	/// </summary>
	[DataMember(Name = "clientIp")]
	public string? ClientIp { get; set; }

	/// <summary>
	/// Channel
	/// </summary>
	[DataMember(Name = "channel")]
	public string? Channel { get; set; }

	/// <summary>
	/// RSSI
	/// </summary>
	[DataMember(Name = "rssi")]
	public string? Rssi { get; set; }

	/// <summary>
	/// Aid
	/// </summary>
	[DataMember(Name = "aid")]
	public string? Aid { get; set; }
}
