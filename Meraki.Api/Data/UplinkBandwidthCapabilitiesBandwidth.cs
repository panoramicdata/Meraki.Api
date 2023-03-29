namespace Meraki.Api.Data;

/// <summary>
/// Uplink bandwidth Capabilities Bandwidth
/// </summary>
[DataContract]
public class UplinkBandwidthCapabilitiesBandwidth
{
	/// <summary>
	/// Interface
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "interface")]
	public string? Interface { get; }

	/// <summary>
	/// Limit
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "limit")]
	public int? Limit { get; }
}
