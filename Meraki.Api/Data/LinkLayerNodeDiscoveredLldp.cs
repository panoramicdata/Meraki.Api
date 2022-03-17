namespace Meraki.Api.Data;

/// <summary>
/// Lldp
/// </summary>
[DataContract]
public class LinkLayerNodeDiscoveredLldp
{
	/// <summary>
	/// Chassis id
	/// </summary>
	[DataMember(Name = "chassisId")]
	public string ChassisId { get; set; } = string.Empty;

	/// <summary>
	/// System name
	/// </summary>
	[DataMember(Name = "systemName")]
	public string SystemName { get; set; } = string.Empty;

	/// <summary>
	/// System description
	/// </summary>
	[DataMember(Name = "systemDescription")]
	public string SystemDescription { get; set; } = string.Empty;

	/// <summary>
	/// System capabilities
	/// </summary>
	[DataMember(Name = "systemCapabilities")]
	public List<string> SystemCapabilities { get; set; } = new();

	/// <summary>
	/// Management address
	/// </summary>
	[DataMember(Name = "managementAddress")]
	public string managementAddress { get; set; } = string.Empty;

	/// <summary>
	/// Port id
	/// </summary>
	[DataMember(Name = "portId")]
	public string PortId { get; set; } = string.Empty;

	/// <summary>
	/// Port description
	/// </summary>
	[DataMember(Name = "portDescription")]
	public string PortDescription { get; set; } = string.Empty;
}
