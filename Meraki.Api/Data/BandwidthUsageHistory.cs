namespace Meraki.Api.Data;

[DataContract]
public class BandwidthUsageHistory
{
	/// <summary>
	/// Ts
	/// </summary>
	[DataMember(Name = "ts")]
	public string Ts { get; set; } = string.Empty;

	/// <summary>
	/// Total
	/// </summary>
	[DataMember(Name = "total")]
	public int Total { get; set; }

	/// <summary>
	/// Upstream
	/// </summary>
	[DataMember(Name = "upstream")]
	public int Upstream { get; set; }

	/// <summary>
	/// Downstream
	/// </summary>
	[DataMember(Name = "downstream")]
	public int Downstream { get; set; }
}
