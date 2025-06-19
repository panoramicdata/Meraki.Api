namespace Meraki.Api.Data;

/// <summary>
/// VTY AAA authorization
/// </summary>
[DataContract]
public class OrganizationInventoryOnboardingCloudMonitoringPrepareCreateRequestDeviceVtyAuthorization
{
	/// <summary>
	/// Group Details
	/// </summary>
	[DataMember(Name = "group")]
	public OrganizationInventoryOnboardingCloudMonitoringPrepareCreateRequestDeviceVtyAuthorizationGroup? Group { get; set; }
}
