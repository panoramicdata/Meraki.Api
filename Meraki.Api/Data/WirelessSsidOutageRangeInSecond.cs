namespace Meraki.Api.Data;

/// <summary>
/// Wireless Ssid Outage Range In Second
/// </summary>
[DataContract]
public class WirelessSsidOutageRangeInSecond
{
	/// <summary>
	/// Seconds since Sunday at midnight when the outage range starts.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "start")]
	public int Start { get; set; }

	/// <summary>
	/// Seconds since Sunday at midnight when that outage range ends.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "end")]
	public int End { get; set; }
}
