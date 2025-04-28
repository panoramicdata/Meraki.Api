namespace Meraki.Api.Data;

/// <summary>
/// Response for the GetNetworkLocationScanningHttpServersAsync method
/// </summary>
public class NetworksLocationScanningHttpServerResponse
{
	/// <summary>
	/// List of location scanning endpoints
	/// </summary>
	public List<NetworksLocationScanningHttpServerEndpoint>? Endpoints { get; set; }
}
