using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// Insight monitored media servers
/// </summary>
[DataContract]
public class InsightMonitoredMediaServers
{
	/// <summary>
	///	Id
	/// </summary>
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	///	Name
	/// </summary>
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	///	Address
	/// </summary>
	[DataMember(Name = "address")]
	public string Address { get; set; } = string.Empty;

	/// <summary>
	///	bestEffortMonitoringEnabled
	/// </summary>
	[DataMember(Name = "bestEffortMonitoringEnabled")]
	public bool BestEffortMonitoringEnabled { get; set; }
}
