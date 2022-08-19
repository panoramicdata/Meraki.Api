namespace Meraki.Api.Data;

/// <summary>
/// Insight monitored media servers
/// </summary>
[DataContract]
public class InsightMonitoredMediaServer : NamedIdentifiedItem
{
	/// <summary>
	///	The IP address (IPv4 only) or hostname of the media server to monitor
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "address")]
	public string Address { get; set; } = string.Empty;

	/// <summary>
	///	Indicates that if the media server doesn't respond to ICMP pings, the nearest hop will be used in its stead
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "bestEffortMonitoringEnabled")]
	public bool BestEffortMonitoringEnabled { get; set; }

	/// <summary>
	/// Undocumented AddressIsAp, believed to be informational only
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "addressIsIp")]
	public bool? AddressIsIp{ get; set; }
}
