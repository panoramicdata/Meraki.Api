namespace Meraki.Api.Data;

/// <summary>
/// Request for the UpdateNetworkLocationScanningAsync method
/// </summary>
public class NetworksLocationScanningUpdateRequest
{
	/// <summary>
	/// Collect Location and scanning analytics
	/// </summary>
	[DataMember(Name = "analyticsEnabled")]
	public bool? AnalyticsEnabled { get; set; }

	/// <summary>
	/// Enable push API for scanning events, analytics must be enabled
	/// </summary>
	[DataMember(Name = "scanningApiEnabled")]
	public bool? ScanningApiEnabled { get; set; }
}
