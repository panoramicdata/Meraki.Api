namespace Meraki.Api.Data;

public class SwitchPortStatus
{
	[DataMember(Name = "portId")]
	public string PortId { get; set; } = string.Empty;

	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }

	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;

	[DataMember(Name = "errors")]
	public List<string> Errors { get; set; } = new();

	[DataMember(Name = "warnings")]
	public List<string> Warnings { get; set; } = new();

	[DataMember(Name = "speed")]
	public string Speed { get; set; } = string.Empty;

	[DataMember(Name = "duplex")]
	public string Duplex { get; set; } = string.Empty;

	[DataMember(Name = "usageInKb")]
	public UsageInKb UsageInKb { get; set; } = new();

	[DataMember(Name = "cdp")]
	public Cdp Cdp { get; set; } = new();

	[DataMember(Name = "lldp")]
	public Lldp Lldp { get; set; } = new();

	[DataMember(Name = "clientCount")]
	public int ClientCount { get; set; }

	[DataMember(Name = "powerUsageInWh")]
	public float PowerUsageInWh { get; set; }

	[DataMember(Name = "trafficInKbps")]
	public TrafficInKbps TrafficInKbps { get; set; } = new();

	[DataMember(Name = "secureConnect")]
	public SecureConnect? SecureConnect { get; set; }
}

public class UsageInKb : Usage
{
	[DataMember(Name = "total")]
	public double Total { get; set; }
}

public class Cdp
{
	[DataMember(Name = "systemName")]
	public string SystemName { get; set; } = string.Empty;

	[DataMember(Name = "platform")]
	public string Platform { get; set; } = string.Empty;

	[DataMember(Name = "deviceId")]
	public string dDeviceId { get; set; } = string.Empty;

	[DataMember(Name = "portId")]
	public string PortId { get; set; } = string.Empty;

	[DataMember(Name = "nativeVlan")]
	public int NativeVlan { get; set; }

	[DataMember(Name = "Address")]
	public string Address { get; set; } = string.Empty;

	[DataMember(Name = "managementAddress")]
	public string ManagementAddress { get; set; } = string.Empty;

	[DataMember(Name = "version")]
	public string Version { get; set; } = string.Empty;

	[DataMember(Name = "vtpManagementDomain")]
	public string VtpManagementDomain { get; set; } = string.Empty;

	[DataMember(Name = "capabilities")]
	public string Capabilities { get; set; } = string.Empty;
}

public class Lldp
{
	[DataMember(Name = "systemName")]
	public string SystemName { get; set; } = string.Empty;

	[DataMember(Name = "systemDescription")]
	public string SystemDescription { get; set; } = string.Empty;

	[DataMember(Name = "portId")]
	public string PortId { get; set; } = string.Empty;

	[DataMember(Name = "portDescription")]
	public string PortDescription { get; set; } = string.Empty;

	[DataMember(Name = "chassisId")]
	public string ChassisId { get; set; } = string.Empty;

	[DataMember(Name = "managementVlan")]
	public int ManagementVlan { get; set; }

	[DataMember(Name = "portVlan")]
	public int PortVlan { get; set; }

	[DataMember(Name = "managementAddress")]
	public string ManagementAddress { get; set; } = string.Empty;

	[DataMember(Name = "systemCapabilities")]
	public string SystemCapabilities { get; set; } = string.Empty;
}

public class TrafficInKbps : Usage
{
	[DataMember(Name = "total")]
	public double Total { get; set; }
}
