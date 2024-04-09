namespace Meraki.Api.Data;

/// <summary>
/// Device Cellular Sims
/// </summary>
[DataContract]
public class DeviceCellularSims
{
	/// <summary>
	/// Specifies which SIMs to use for primary and secondary. Required for devices with 3 or more SIMs.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "simOrdering")]
	public List<string>? SimOrdering { get; set; }

	/// <summary>
	/// Sim Failover
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "simFailover")]
	public DeviceCellularSimsSimFailover? SimFailover { get; set; }

	/// <summary>
	/// A list of Sims
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "sims")]
	public List<DeviceCellularSimsSim>? Sims { get; set; }
}
