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

	/// <summary>
	/// Device system description
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "systemDescription")]
	public string? SystemDescription { get; set; }

	/// <summary>
	/// Port description
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "portDescription")]
	public string? PortDescription { get; set; }

	/// <summary>
	/// Chassis ID
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "chassisId")]
	public string? ChassisId { get; set; }

	/// <summary>
	/// Management VLAN
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "managementVlan")]
	public int? ManagementVlan { get; set; }

	/// <summary>
	/// Port VLAN
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "portVlan")]
	public int? PortVlan { get; set; }

	/// <summary>
	/// System capabilities
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "systemCapabilities")]
	public string? SystemCapabilities { get; set; }
}
