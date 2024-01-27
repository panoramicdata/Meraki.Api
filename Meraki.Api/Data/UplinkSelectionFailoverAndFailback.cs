namespace Meraki.Api.Data;

/// <summary>
/// Uplink selection Failover and Failback
/// </summary>
[DataContract]
public class UplinkSelectionFailoverAndFailback
{
	/// <summary>
	/// Immediate WAN failover and failback
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "immediate")]
	public UplinkSelectionFailoverAndFailbackImmediate? Immediate { get; set; }
}
