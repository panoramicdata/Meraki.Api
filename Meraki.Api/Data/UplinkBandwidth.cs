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

	/// <summary>
	/// Capabilities
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "capabilities")]
	public List<UplinkBandwidthCapability>? Capabilities { get; }
}
