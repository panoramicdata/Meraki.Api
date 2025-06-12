namespace Meraki.Api.Data;

/// <summary>
/// VTY AAA authentication
/// </summary>
[DataContract]
public class OrganizationInventoryOnboardingCloudMonitoringPrepareCreateRequestDeviceVtyAuthentication
{
	/// <summary>
	/// Group Details
	/// </summary>
	[DataMember(Name = "group")]
	public OrganizationInventoryOnboardingCloudMonitoringPrepareCreateRequestDeviceVtyAuthenticationGroup? Group { get; set; }
}
