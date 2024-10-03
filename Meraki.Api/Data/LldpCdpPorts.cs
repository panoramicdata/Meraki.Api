namespace Meraki.Api.Data;

/// <summary>
/// LldpCdp Ports
/// </summary>
[DataContract]
public class LldpCdpPorts
{
	/// <summary>
	/// cdp information
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "cdp")]
	public LldpCdpPortsCdp Cdp { get; set; } = new();

	/// <summary>
	/// Associated device information
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "device")]
	public LldpCdpPortsDevice Device { get; set; } = new();

	/// <summary>
	/// lldp information
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "lldp")]
	public LldpCdpPortsLldp Lldp { get; set; } = new();
}
