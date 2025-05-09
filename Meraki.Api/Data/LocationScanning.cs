namespace Meraki.Api.Data;

/// <summary>
/// Location Scanning
/// </summary>
[DataContract]
public class LocationScanning
{
	/// <summary>
	/// Whether to enable collection of location and scanning analytics
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }

	/// <summary>
	/// Whether to enable collection of location and scanning analytics
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "api")]
	public LocationScanningApiDetailed Api { get; set; } = new();
}
