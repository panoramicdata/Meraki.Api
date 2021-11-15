namespace Meraki.Api.Data;

/// <summary>
/// A mapping of uplinks to their bandwidth settings (be sure to check which uplinks are supported for your network)
/// </summary>
[DataContract]
public class UplinkBandwidthLimits
{
	/// <summary>
	/// The bandwidth settings for the 'wan1' uplink
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "wan1")]
	public BandwidthLimit Wan1 { get; set; } = new();

	/// <summary>
	/// The bandwidth settings for the 'wan2' uplink
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "wan2")]
	public BandwidthLimit Wan2 { get; set; } = new();

	/// <summary>
	/// The bandwidth settings for the 'cellular' uplink
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "cellular")]
	public BandwidthLimit Cellular { get; set; } = new();
}
