namespace Meraki.Api.Data;

/// <summary>
/// Uplink bandwidth Capabilities
/// </summary>
[DataContract]
public class UplinkBandwidthCapability
{
	/// <summary>
	/// Model
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "model")]
	public string? Model { get; }

	/// <summary>
	/// Bandwidths
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "bandwidths")]
	public List<UplinkBandwidthCapabilitiesBandwidth>? Bandwidths { get; }
}
