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
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "destinations")]
	public List<Destination> Destinations { get; set; } = new();
}
