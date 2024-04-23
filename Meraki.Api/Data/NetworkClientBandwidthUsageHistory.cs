namespace Meraki.Api.Data;
/// <summary>
/// Bandwidth usage
/// </summary>
[DataContract]

public class NetworkClientBandwidthUsageHistory
{
	/// <summary>
	/// TS
	/// </summary>
	[DataMember(Name = "ts")]
	public string Ts { get; set; } = string.Empty;

	/// <summary>
	/// Total
	/// </summary>
	[DataMember(Name = "total")]
	public int Total { get; set; }

	/// <summary>
	/// The downstream traffic over a time range for clients on a network
	/// </summary>
	[DataMember(Name = "downstream")]
	public double Downstream { get; set; }

	/// <summary>
	/// The upstream traffic over a time range for clients on a network
	/// </summary>
	[DataMember(Name = "upstream")]
	public double Upstream { get; set; }
}
