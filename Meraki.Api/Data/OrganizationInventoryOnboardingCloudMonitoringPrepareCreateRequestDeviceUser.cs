namespace Meraki.Api.Data;

/// <summary>
/// User parameters
/// </summary>
[DataContract]
public class OrganizationInventoryOnboardingCloudMonitoringPrepareCreateRequestDeviceUser
{
	/// <summary>
	/// The name of the device user for Meraki monitoring
	/// </summary>
	[DataMember(Name = "username")]
	public string? Username { get; set; }
}