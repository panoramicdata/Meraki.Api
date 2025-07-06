namespace Meraki.Api.Data;

/// <summary>
/// Configuration options used to connect to the device
/// </summary>
[DataContract]
public class OrganizationInventoryOnboardingCloudMonitoringPrepareItemConfigParamsTunnel
{
	/// <summary>
	/// SSH tunnel URL used to connect to the device
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "host")]
	public string Host { get; set; } = string.Empty;

	/// <summary>
	/// Mode
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "mode")]
	public string Mode { get; set; } = string.Empty;

	/// <summary>
	/// The name of the tunnel we are attempting to connect to
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// The port used for the ssh tunnel.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "port")]
	public string Port { get; set; } = string.Empty;

	/// <summary>
	/// Root certificate information
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "rootCertificate")]
	public OrganizationInventoryOnboardingCloudMonitoringPrepareItemConfigParamsTunnelRootCertificate RootCertificate { get; set; } = new();
}
