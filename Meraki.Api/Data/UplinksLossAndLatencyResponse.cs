namespace Meraki.Api.Data;

/// <summary>
/// Response
/// </summary>
[DataContract]
public class UplinksLossAndLatencyResponse
{
	/// <summary>
	/// Network id
	/// </summary>
	[DataMember(Name = "networkId")]
	public string NetworkId { get; set; } = string.Empty;

	/// <summary>
	/// Serial
	/// </summary>
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// Uplink
	/// </summary>
	[DataMember(Name = "uplink")]
	public string Uplink { get; set; } = string.Empty;

	/// <summary>
	/// Ip
	/// </summary>
	[DataMember(Name = "ip")]
	public string Ip { get; set; } = string.Empty;

	/// <summary>
	/// Time series
	/// </summary>
	[DataMember(Name = "timeSeries")]
	public List<TimeSeries> TimeSeries { get; set; } = new();
}
