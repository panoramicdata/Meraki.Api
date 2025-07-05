namespace Meraki.Api.Data;

/// <summary>
/// A set of devices to import (or update)
/// </summary>
[DataContract]
public class OrganizationInventoryOnboardingCloudMonitoringPrepareCreateRequestDevice
{
	/// <summary>
	/// Device SUDI certificate
	/// </summary>
	[DataMember(Name = "sudi")]
	public string Sudi { get; set; } = string.Empty;

	/// <summary>
	/// TLS Related Parameters
	/// </summary>
	[DataMember(Name = "tunnel")]
	public OrganizationInventoryOnboardingCloudMonitoringPrepareCreateRequestDeviceTunnel? Tunnel { get; set; }

	/// <summary>
	/// User parameters
	/// </summary>
	[DataMember(Name = "user")]
	public OrganizationInventoryOnboardingCloudMonitoringPrepareCreateRequestDeviceUser? User { get; set; }

	/// <summary>
	/// VTY Related Parameters
	/// </summary>
	[DataMember(Name = "vty")]
	public OrganizationInventoryOnboardingCloudMonitoringPrepareCreateRequestDeviceVty? Vty { get; set; }
}
