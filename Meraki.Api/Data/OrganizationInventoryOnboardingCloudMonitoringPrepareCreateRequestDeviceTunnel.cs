namespace Meraki.Api.Data;

/// <summary>
/// TLS Related Parameters
/// </summary>
[DataContract]
public class OrganizationInventoryOnboardingCloudMonitoringPrepareCreateRequestDeviceTunnel
{
	/// <summary>
	/// Number of the vlan expected to be used to connect to the cloud
	/// </summary>
	[DataMember(Name = "localInterface")]
	public int? LocalInterface { get; set; }

	/// <summary>
	/// Number of the configured Loopback Interface used for TLS overlay
	/// </summary>
	[DataMember(Name = "loopbackNumber")]
	public int? LoopbackNumber { get; set; }

	/// <summary>
	/// Name of the configured TLS certificate
	/// </summary>
	[DataMember(Name = "certificateName")]
	public string? CertificateName { get; set; }

	/// <summary>
	/// Name of the configured TLS tunnel
	/// </summary>
	[DataMember(Name = "name")]
	public string? Name { get; set; }
}