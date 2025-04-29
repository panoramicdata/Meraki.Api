namespace Meraki.Api.Data;

/// <summary>
/// Response for the GetNetworkLocationScanningAsync method
/// </summary>
[DataContract]
public class NetworksLocationScanningResponse
{
	/// <summary>
	/// Validator for the push API
	/// </summary>
	[DataMember(Name = "validator")]
	public string? Validator { get; set; }

	/// <summary>
	/// Whether to enable collection of location and scanning analytics
	/// </summary>
	[DataMember(Name = "analyticsEnabled")]
	public bool? AnalyticsEnabled { get; set; }

	/// <summary>
	/// Whether to enable push API for scanning events. Analytiscs must be enabled to enable scanning API
	/// </summary>
	[DataMember(Name = "scanningApiEnabled")]
	public bool? ScanningApiEnabled { get; set; }
}
