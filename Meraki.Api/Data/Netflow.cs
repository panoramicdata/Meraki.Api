namespace Meraki.Api.Data;

/// <summary>
/// UpdateNetworkNetflowSettings
/// </summary>
[DataContract]
public class Netflow
{
	/// <summary>
	/// Boolean indicating whether NetFlow traffic reporting is enabled (true) or disabled (false).
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "reportingEnabled")]
	public bool ReportingEnabled { get; set; }

	/// <summary>
	/// The IPv4 address of the NetFlow collector.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "collectorIp")]
	public string CollectorIp { get; set; } = string.Empty;

	/// <summary>
	/// The port that the NetFlow collector will be listening on.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "collectorPort")]
	public int CollectorPort { get; set; }

	/// <summary>
	/// Boolean indicating whether Encrypted Traffic Analysis is enabled (true) or disabled (false).
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "etaEnabled")]
	public bool EtaEnabled { get; set; }

	/// <summary>
	/// The port that the Encrypted Traffic Analysis collector will be listening on.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "etaDstPort")]
	public int EtaDstPort { get; set; }
}
