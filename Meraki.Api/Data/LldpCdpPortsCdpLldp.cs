namespace Meraki.Api.Data;

/// <summary>
/// LldpCdp Ports Lldp
/// </summary>
[DataContract]
public class LldpCdpPortsLldp
{
	/// <summary>
	/// Management IP address
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "managementAddress")]
	public string? ManagementAddress { get; set; }

	/// <summary>
	/// ID for the port
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "portId")]
	public string? PortId { get; set; }

	/// <summary>
	/// Source port
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "sourcePort")]
	public string? SourcePort { get; set; }

	/// <summary>
	/// Device system name
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "systemName")]
	public string? SystemName { get; set; }
}
