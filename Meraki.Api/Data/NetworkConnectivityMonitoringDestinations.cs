namespace Meraki.Api.Data;

/// <summary>
/// UpdateNetworkConnectivityMonitoringDestinations
/// </summary>
[DataContract]
public class NetworkConnectivityMonitoringDestinations
{
	/// <summary>
	/// The list of connectivity monitoring destinations
	/// </summary>
	/// <value>The list of connectivity monitoring destinations</value>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "destinations")]
	public List<Destination> Destinations { get; set; } = new();
}
