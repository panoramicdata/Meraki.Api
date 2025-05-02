namespace Meraki.Api.Data;

/// <summary>
/// List of location Scanning Endpoints
/// </summary>
[DataContract]
public class NetworksLocationScanningHttpServerEndpoint
{
	/// <summary>
	/// Version of the scanning API
	/// </summary>
	[DataMember(Name = "scanningApiVersion")]
	[ApiAccess(ApiAccess.ReadUpdate)]
	public int? ScanningApiVersion { get; set; }

	/// <summary>
	/// Timestamp, in ISO8601, when the operation was completed successfully
	/// </summary>
	[DataMember(Name = "errorAt")]
	[ApiAccess(ApiAccess.ReadUpdate)]
	public string? ErrorAt { get; set; }

	/// <summary>
	/// Errors if any in JSON Format
	/// </summary>
	[DataMember(Name = "postErrors")]
	[ApiAccess(ApiAccess.ReadUpdate)]
	public string? PostErrors { get; set; }

	/// <summary>
	/// Radio type to use for scanning: 'WiFi' or 'BLE' 
	/// </summary>
	[DataMember(Name = "radioType")]
	[ApiAccess(ApiAccess.ReadUpdate)]
	public NetworksLocationScanningHttpServerRadioType? RadioType { get; set; }

	/// <summary>
	/// Timestamp, in ISO8601, when the operation was completed successfully
	/// </summary>
	[DataMember(Name = "successAt")]
	[ApiAccess(ApiAccess.ReadUpdate)]
	public string? SuccessAt { get; set; }

	/// <summary>
	/// Endpoint http server information
	/// </summary>
	[DataMember(Name = "httpServer")]
	[ApiAccess(ApiAccess.ReadUpdate)]
	public NetworksLocationScanningHttpServer? HttpServer { get; set; }
}