namespace Meraki.Api.Data;

/// <summary>
/// VTY in ACL
/// </summary>
[DataContract]
public class OrganizationInventoryOnboardingCloudMonitoringPrepareCreateRequestDeviceVtyAccessListVtyIn
{
	/// <summary>
	/// Name
	/// </summary>
	[DataMember(Name = "name")]
	public string? Name { get; set; }
}