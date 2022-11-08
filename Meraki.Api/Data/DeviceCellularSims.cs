namespace Meraki.Api.Data;

/// <summary>
/// Device Cellular Sims
/// </summary>
[DataContract]
public class DeviceCellularSims
{
	/// <summary>
	/// Sim Failover
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "simFailover")]
	public List<DeviceCellularSimsSimFailover> SimFailover { get; set; } = new();

	/// <summary>
	/// A list of Sims
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "sims")]
	public List<DeviceCellularSimsSim> Sims { get; set; } = new();
}
