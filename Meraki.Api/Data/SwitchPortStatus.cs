namespace Meraki.Api.Data;

/// <summary>
/// Switch Port Status
/// </summary>
[ApiAccessReadOnlyClass]
public class SwitchPortStatus
{
	/// <summary>
	/// Gets the port id
	/// </summary>
	[DataMember(Name = "portId")]
	public string PortId { get; set; } = string.Empty;

	/// <summary>
	/// Whether enabled
	/// </summary>
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }

	/// <summary>
	/// Whether uplink
	/// </summary>
	[DataMember(Name = "isUplink")]
	public bool? IsUplink { get; set; }

	/// <summary>
	/// Gets the status
	/// </summary>
	[DataMember(Name = "status")]
	public string? Status { get; set; }

	/// <summary>
	/// Gets the errors
	/// </summary>
	[DataMember(Name = "errors")]
	public List<string>? Errors { get; set; }

	/// <summary>
	/// Gets the warnings
	/// </summary>
	[DataMember(Name = "warnings")]
	public List<string>? Warnings { get; set; }

	/// <summary>
	/// Gets the speed
	/// </summary>
	[DataMember(Name = "speed")]
	public string? Speed { get; set; }

	/// <summary>
	/// Gets the duplex
	/// </summary>
	[DataMember(Name = "duplex")]
	public string? Duplex { get; set; }

	/// <summary>
	/// Gets the usage in kb
	/// </summary>
	[DataMember(Name = "usageInKb")]
	public UsageInKb? UsageInKb { get; set; }

	/// <summary>
	/// Gets the cdp
	/// </summary>
	[DataMember(Name = "cdp")]
	public Cdp? Cdp { get; set; }

	/// <summary>
	/// Gets the lldp
	/// </summary>
	[DataMember(Name = "lldp")]
	public Lldp? Lldp { get; set; }

	/// <summary>
	/// Gets the client count
	/// </summary>
	[DataMember(Name = "clientCount")]
	public int? ClientCount { get; set; }

	/// <summary>
	/// Gets the power usage in wh
	/// </summary>
	[DataMember(Name = "powerUsageInWh")]
	public double? PowerUsageInWh { get; set; }

	/// <summary>
	/// Gets the traffic in kbps
	/// </summary>
	[DataMember(Name = "trafficInKbps")]
	public TrafficInKbps? TrafficInKbps { get; set; }

	/// <summary>
	/// Gets the secure port
	/// </summary>
	[DataMember(Name = "securePort")]
	public SwitchPortStatusSecurePort? SecurePort { get; set; }

	/// <summary>
	/// Gets the spanning tree
	/// </summary>
	[DataMember(Name = "spanningTree")]
	public SwitchPortStatusSpanningTree? SpanningTree { get; set; }

	/// <summary>
	/// Gets the poe
	/// </summary>
	[DataMember(Name = "poe")]
	public SwitchPortStatusPoe? Poe { get; set; }
}

/// <summary>
/// Usage In Kb
/// </summary>
public class UsageInKb : Usage
{
	/// <summary>
	/// Gets the total
	/// </summary>
	[DataMember(Name = "total")]
	public double? Total { get; set; }
}

/// <summary>
/// Cdp
/// </summary>
public class Cdp
{
	/// <summary>
	/// Gets the system name
	/// </summary>
	[DataMember(Name = "systemName")]
	public string? SystemName { get; set; }

	/// <summary>
	/// Gets the platform
	/// </summary>
	[DataMember(Name = "platform")]
	public string? Platform { get; set; }

	/// <summary>
	/// Gets the device id
	/// </summary>
	[DataMember(Name = "deviceId")]
	public string? DeviceId { get; set; }

	/// <summary>
	/// Gets the port id
	/// </summary>
	[DataMember(Name = "portId")]
	public string? PortId { get; set; }

	/// <summary>
	/// Gets the native vlan
	/// </summary>
	[DataMember(Name = "nativeVlan")]
	public int? NativeVlan { get; set; }

	/// <summary>
	/// Gets the address
	/// </summary>
	[DataMember(Name = "Address")]
	public string? Address { get; set; }

	/// <summary>
	/// Gets the management address
	/// </summary>
	[DataMember(Name = "managementAddress")]
	public string? ManagementAddress { get; set; }

	/// <summary>
	/// Gets the version
	/// </summary>
	[DataMember(Name = "version")]
	public string? Version { get; set; }

	/// <summary>
	/// Gets the vtp management domain
	/// </summary>
	[DataMember(Name = "vtpManagementDomain")]
	public string? VtpManagementDomain { get; set; }

	/// <summary>
	/// Gets the capabilities
	/// </summary>
	[DataMember(Name = "capabilities")]
	public string? Capabilities { get; set; }
}

/// <summary>
/// Lldp
/// </summary>
public class Lldp
{
	/// <summary>
	/// Gets the system name
	/// </summary>
	[DataMember(Name = "systemName")]
	public string? SystemName { get; set; }

	/// <summary>
	/// Gets the system description
	/// </summary>
	[DataMember(Name = "systemDescription")]
	public string? SystemDescription { get; set; }

	/// <summary>
	/// Gets the port id
	/// </summary>
	[DataMember(Name = "portId")]
	public string? PortId { get; set; }

	/// <summary>
	/// Gets the port description
	/// </summary>
	[DataMember(Name = "portDescription")]
	public string? PortDescription { get; set; }

	/// <summary>
	/// Gets the chassis id
	/// </summary>
	[DataMember(Name = "chassisId")]
	public string? ChassisId { get; set; }

	/// <summary>
	/// Gets the management vlan
	/// </summary>
	[DataMember(Name = "managementVlan")]
	public int? ManagementVlan { get; set; }

	/// <summary>
	/// Gets the port vlan
	/// </summary>
	[DataMember(Name = "portVlan")]
	public int? PortVlan { get; set; }

	/// <summary>
	/// Gets the management address
	/// </summary>
	[DataMember(Name = "managementAddress")]
	public string? ManagementAddress { get; set; }

	/// <summary>
	/// Gets the system capabilities
	/// </summary>
	[DataMember(Name = "systemCapabilities")]
	public string? SystemCapabilities { get; set; }
}

/// <summary>
/// Traffic In Kbps
/// </summary>
public class TrafficInKbps : Usage
{
	/// <summary>
	/// Gets the total
	/// </summary>
	[DataMember(Name = "total")]
	public double? Total { get; set; }
}
