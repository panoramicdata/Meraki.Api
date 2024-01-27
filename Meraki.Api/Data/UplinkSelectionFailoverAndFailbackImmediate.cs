namespace Meraki.Api.Data;

/// <summary>
/// Uplink selection Failover and Failback Immediate
/// </summary>
[DataContract]
public class UplinkSelectionFailoverAndFailbackImmediate
{
	/// <summary>
	/// Whether immediate WAN failover and failback is enabled
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }
}
