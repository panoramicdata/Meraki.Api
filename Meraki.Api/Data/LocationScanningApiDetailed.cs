namespace Meraki.Api.Data;

/// <summary>
/// Whether to enable collection of location and scanning analytics.
/// </summary>
[DataContract]
public class LocationScanningApiDetailed
{
	/// <summary>
	/// Whether to enable push API for scanning events. Analytics must be enabled to enable scanning API
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }

	/// <summary>
	/// Validator for push API
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "validator")]
	public LocationScanningApiValidator Validator { get; set; } = new();
}
