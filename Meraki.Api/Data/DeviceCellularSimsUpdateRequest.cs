namespace Meraki.Api.Data;

/// <summary>
/// Device Cellular Sims
/// </summary>
[DataContract]
public class DeviceCellularSimsUpdateRequest
{
	/// <summary>
	/// Specifies the ordering of all SIMs for an MG: primary, secondary, and not-in-use (when applicable).
	/// It's required for devices with 3 or more SIMs and can be used in place of 'isPrimary' for dual-SIM devices.
	/// To indicate eSIM, use 'sim3'. Sim failover will occur only between primary and secondary sim slots.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "simOrdering")]
	public List<string>? SimOrdering { get; set; }

	/// <summary>
	/// SIM Failover settings.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "simFailover")]
	public DeviceCellularSimsSimFailover? SimFailover { get; set; }

	/// <summary>
	/// List of SIMs. If a SIM was previously configured and not specified in this request, it will remain unchanged.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "sims")]
	public List<DeviceCellularSimsSim>? Sims { get; set; }
}
