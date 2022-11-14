namespace Meraki.Api.Data;

/// <summary>
/// Device Cellular Sims SimFailover
/// </summary>
[DataContract]
public class DeviceCellularSimsSimFailover
{
	/// <summary>
	/// Failover
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "failover")]
	public bool? Failover { get; set; }
}
