namespace Meraki.Api.Data;

/// <summary>
/// Group Details
/// </summary>
[DataContract]
public class OrganizationInventoryOnboardingCloudMonitoringPrepareCreateRequestDeviceVtyAuthorizationGroup
{
	/// <summary>
	/// Group Name
	/// </summary>
	[DataMember(Name = "name")]
	public string? Name { get; set; }
}