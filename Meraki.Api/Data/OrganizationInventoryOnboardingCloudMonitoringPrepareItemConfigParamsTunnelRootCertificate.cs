namespace Meraki.Api.Data;

/// <summary>
/// Root certificate information
/// </summary>
[DataContract]
public class OrganizationInventoryOnboardingCloudMonitoringPrepareItemConfigParamsTunnelRootCertificate
{
	/// <summary>
	/// Public certificate value
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "content")]
	public string Content { get; set; } = string.Empty;

	/// <summary>
	/// The name of the server protected by the certificate
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;
}