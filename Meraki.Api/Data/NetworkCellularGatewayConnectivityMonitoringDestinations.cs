namespace Meraki.Api.Data;

/// <summary>
/// UpdateNetworkCellularGatewaySettingsConnectivityMonitoringDestinations
/// </summary>
[DataContract]
public class NetworkCellularGatewayConnectivityMonitoringDestinations
{
	/// <summary>
	/// The list of connectivity monitoring destinations
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "destinations")]
	public List<Destination> Destinations { get; set; } = [];
}
