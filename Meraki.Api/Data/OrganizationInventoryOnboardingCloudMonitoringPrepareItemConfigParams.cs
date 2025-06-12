namespace Meraki.Api.Data;

/// <summary>
/// Params used in order to connect to the device
/// </summary>
[DataContract]
public class OrganizationInventoryOnboardingCloudMonitoringPrepareItemConfigParams
{
	/// <summary>
	/// Static IP Address used to connect to the device
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "cloudStaticIp")]
	public string CloudStaticIp { get; set; } = string.Empty;

	/// <summary>
	/// Configuration options used to connect to the device
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "tunnel")]
	public OrganizationInventoryOnboardingCloudMonitoringPrepareItemConfigParamsTunnel Tunnel { get; set; } = new();

	/// <summary>
	/// User credentials used to connect to the device
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "user")]
	public OrganizationInventoryOnboardingCloudMonitoringPrepareItemConfigParamsUser User { get; set; } = new();
}
