namespace Meraki.Api.Data;

/// <summary>
/// Enable push API for scanning events, analytics must be enabled
/// </summary>
[DataContract]
public class LocationScanningUpdateRequestApi
{
	/// <summary>
	/// Enable push API for scanning events, analytics must be enabled
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }
}