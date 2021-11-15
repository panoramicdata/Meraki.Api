namespace Meraki.Api.Data;

/// <summary>
/// The bandwidth settings for an uplink
/// </summary>
[DataContract]
public class BandwidthLimit
{
	/// <summary>
	/// The maximum upload limit (integer, in Kbps). null indicates no limit
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "limitUp")]
	public int? LimitUp { get; set; }
	/// <summary>
	/// The maximum download limit (integer, in Kbps). null indicates no limit
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "limitDown")]
	public int? LimitDown { get; set; }
}
