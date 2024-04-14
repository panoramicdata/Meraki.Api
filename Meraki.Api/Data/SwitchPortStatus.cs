namespace Meraki.Api.Data;

[ApiAccessReadOnlyClass]
public class SwitchPortStatus
{
	[DataMember(Name = "portId")]
	public string PortId { get; set; } = string.Empty;

	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }

	[DataMember(Name = "isUplink")]
	public bool? IsUplink { get; set; }

	[DataMember(Name = "status")]
	public string? Status { get; set; }

	[DataMember(Name = "errors")]
	public List<string>? Errors { get; set; }

	[DataMember(Name = "warnings")]
	public List<string>? Warnings { get; set; }

	[DataMember(Name = "speed")]
	public string? Speed { get; set; }

	[DataMember(Name = "duplex")]
	public string? Duplex { get; set; }

	[DataMember(Name = "usageInKb")]
	public UsageInKb? UsageInKb { get; set; }

	[DataMember(Name = "cdp")]
	public Cdp? Cdp { get; set; }

	[DataMember(Name = "lldp")]
	public Lldp? Lldp { get; set; }

	[DataMember(Name = "clientCount")]
	public int? ClientCount { get; set; }

	[DataMember(Name = "powerUsageInWh")]
	public double? PowerUsageInWh { get; set; }

	[DataMember(Name = "trafficInKbps")]
	public TrafficInKbps? TrafficInKbps { get; set; }

	[DataMember(Name = "securePort")]
	public SwitchPortStatusSecurePort? SecurePort { get; set; }

	[DataMember(Name = "spanningTree")]
	public SwitchPortStatusSpanningTree? SpanningTree { get; set; }
}

public class UsageInKb : Usage
{
	[DataMember(Name = "total")]
	public double? Total { get; set; }
}

public class Cdp
{
	[DataMember(Name = "systemName")]
	public string? SystemName { get; set; }

	[DataMember(Name = "platform")]
	public string? Platform { get; set; }

	[DataMember(Name = "deviceId")]
	public string? DeviceId { get; set; }

	[DataMember(Name = "portId")]
	public string? PortId { get; set; }

	[DataMember(Name = "nativeVlan")]
	public int? NativeVlan { get; set; }

	[DataMember(Name = "Address")]
	public string? Address { get; set; }

	[DataMember(Name = "managementAddress")]
	public string? ManagementAddress { get; set; }

	[DataMember(Name = "version")]
	public string? Version { get; set; }

	[DataMember(Name = "vtpManagementDomain")]
	public string? VtpManagementDomain { get; set; }

	[DataMember(Name = "capabilities")]
	public string? Capabilities { get; set; }
}

public class Lldp
{
	[DataMember(Name = "systemName")]
	public string? SystemName { get; set; }

	[DataMember(Name = "systemDescription")]
	public string? SystemDescription { get; set; }

	[DataMember(Name = "portId")]
	public string? PortId { get; set; }

	[DataMember(Name = "portDescription")]
	public string? PortDescription { get; set; }

	[DataMember(Name = "chassisId")]
	public string? ChassisId { get; set; }

	[DataMember(Name = "managementVlan")]
	public int? ManagementVlan { get; set; }

	[DataMember(Name = "portVlan")]
	public int? PortVlan { get; set; }

	[DataMember(Name = "managementAddress")]
	public string? ManagementAddress { get; set; }

	[DataMember(Name = "systemCapabilities")]
	public string? SystemCapabilities { get; set; }
}

public class TrafficInKbps : Usage
{
	[DataMember(Name = "total")]
	public double? Total { get; set; }
}
