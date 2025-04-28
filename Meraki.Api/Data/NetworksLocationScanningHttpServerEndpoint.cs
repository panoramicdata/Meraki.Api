namespace Meraki.Api.Data;

/// <summary>
/// List of location Scanning Endpoints
/// </summary>
public class NetworksLocationScanningHttpServerEndpoint
{
	/// <summary>
	/// Version of the scanning API
	/// </summary>
	[DataMember(Name = "scanningApiVersion")]
	public int? ScanningApiVersion { get; set; }

	/// <summary>
	/// Timestamp, in ISO8601, when the operation was completed successfully
	/// </summary>
	[DataMember(Name = "errorAt")]
	public string? ErrorAt { get; set; }

	/// <summary>
	/// Errors if any in JSON Format
	/// </summary>
	[DataMember(Name = "postErrors")]
	public string? PostErrors { get; set; }

	/// <summary>
	/// Radio type to use for scanning: 'WiFi' or 'BLE' 
	/// </summary>
	[DataMember(Name = "radioType")]
	public NetworksLocationScanningHttpServerRadioType? RadioType { get; set; }

	/// <summary>
	/// Timestamp, in ISO8601, when the operation was completed successfully
	/// </summary>
	[DataMember(Name = "successAt")]
	public string? SuccessAt { get; set; }

	/// <summary>
	/// Endpoint http server information
	/// </summary>
	[DataMember(Name = "httpServer")]
	public NetworksLocationScanningHttpServer? HttpServer { get; set; }
}