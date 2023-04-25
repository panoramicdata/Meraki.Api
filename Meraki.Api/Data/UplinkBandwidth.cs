namespace Meraki.Api.Data;

/// <summary>
/// Uplink bandwidth
/// </summary>
[DataContract]
public class UplinkBandwidth
{
	/// <summary>
	/// Bandwidth limits
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "bandwidthLimits")]
	public UplinkBandwidthLimits? BandwidthLimits { get; set; }
}
