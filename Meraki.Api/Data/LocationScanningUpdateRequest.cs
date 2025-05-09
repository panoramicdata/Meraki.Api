namespace Meraki.Api.Data;

/// <summary>
/// Location Scanning Update Request
/// </summary>
[DataContract]
public class LocationScanningUpdateRequest
{
	/// <summary>
	/// Collect location and scanning analytics
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }

	/// <summary>
	/// Enable push API for scanning events. Analytics must be enabled to enable scanning API
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "api")]
	public LocationScanningUpdateRequestApi Api { get; set; } = new();
}
