namespace Meraki.Api.Data;

/// <summary>
/// A Set of HTTP server configurations
/// </summary>
public class NetworksLocationScanningHttpServerRequestEndpoints
{
	/// <summary>
	/// API version that the receiver expects to get 1, 2, or 3
	/// </summary>
	public int ScanningApiVersion { get; set; }

	/// <summary>
	/// Radio Type to use for Scanning; "WiFi" or "BLE"
	/// </summary>
	public NetworksLocationScanningHttpServerRadioType RadioType { get; set; }

	/// <summary>
	/// A HTTP Server object
	/// </summary>
	public NetworksLocationScanningHttpServerSimple HttpServer { get; set; } = new();
}