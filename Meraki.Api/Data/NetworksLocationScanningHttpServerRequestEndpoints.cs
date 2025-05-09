namespace Meraki.Api.Data;

/// <summary>
/// A Set of HTTP server configurations
/// </summary>
[DataContract]
public class NetworksLocationScanningHttpServerRequestEndpoints
{
	/// <summary>
	/// API version that the receiver expects to get 1, 2, or 3
	/// </summary>
	[DataMember(Name = "scanningApiVersion")]
	public int ScanningApiVersion { get; set; }

	/// <summary>
	/// Radio Type to use for Scanning; "WiFi" or "BLE"
	/// </summary>
	[DataMember(Name = "radioType")]
	public NetworksLocationScanningHttpServerRadioType RadioType { get; set; }

	/// <summary>
	/// A HTTP Server object
	/// </summary>
	[DataMember(Name = "httpServer")]
	public NetworksLocationScanningHttpServerSimple HttpServer { get; set; } = new();
}