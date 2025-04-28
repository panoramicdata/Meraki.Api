namespace Meraki.Api.Data;

/// <summary>
/// Represents a request for the UpdateNetworkLocationScanningHttpServersAsync method
/// </summary>
public class NetworksLocationScanningHttpServerUpdateRequest
{
	/// <summary>
	/// A set of http server configurations
	/// </summary>
	public NetworksLocationScanningHttpServerRequestEndpoints Endpoints { get; set; }
}
