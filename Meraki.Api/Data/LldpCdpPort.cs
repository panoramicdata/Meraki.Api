namespace Meraki.Api.Data;

/// <summary>
/// LldpCdp Port
/// </summary>
[DataContract]
public class LldpCdpPort
{
	/// <summary>
	/// MAC address for the device
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "deviceMac")]
	public string DeviceMac { get; set; } = string.Empty;

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
