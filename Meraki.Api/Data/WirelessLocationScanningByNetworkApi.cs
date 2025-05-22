namespace Meraki.Api.Data;

/// <summary>
/// Whether to enable collection of location and scanning analytics
/// </summary>
[DataContract]
public class WirelessLocationScanningByNetworkApi
{
	/// <summary>
	/// Whether to enable collection of location and scanning analytics.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }

	/// <summary>
	/// Validator for push API
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "validator")]
	public WirelessLocationScanningByNetworkApiValidator Validator { get; set; } = new();
}
