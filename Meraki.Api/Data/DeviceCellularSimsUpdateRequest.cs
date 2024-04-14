namespace Meraki.Api.Data;

/// <summary>
/// Device Cellular Sims
/// </summary>
[DataContract]
public class DeviceCellularSimsUpdateRequest
{
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
