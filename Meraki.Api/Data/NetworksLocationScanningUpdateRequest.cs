namespace Meraki.Api.Data;

/// <summary>
/// Request for the UpdateNetworkLocationScanningAsync method
/// </summary>
[DataContract]
public class NetworksLocationScanningUpdateRequest
{
	/// <summary>
	/// Collect Location and scanning analytics
	/// </summary>
	[DataMember(Name = "analyticsEnabled")]
	[ApiAccess(ApiAccess.Update)]
	public bool? AnalyticsEnabled { get; set; }

	/// <summary>
	/// Enable push API for scanning events, analytics must be enabled
	/// </summary>
	[DataMember(Name = "scanningApiEnabled")]
	[ApiAccess(ApiAccess.Update)]
	public bool? ScanningApiEnabled { get; set; }
}
