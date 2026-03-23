namespace Meraki.Api.Data;

/// <summary>
/// RADIUS accounting device profiling settings for an SSID
/// </summary>
[DataContract]
public class SsidRadiusAccountingDeviceProfiling
{
	/// <summary>
	/// Whether RADIUS accounting device profiling is enabled
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }
}