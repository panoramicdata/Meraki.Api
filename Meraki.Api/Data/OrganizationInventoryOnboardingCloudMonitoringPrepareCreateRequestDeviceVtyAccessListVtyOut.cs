namespace Meraki.Api.Data;

/// <summary>
/// VTY out ACL
/// </summary>
[DataContract]
public class OrganizationInventoryOnboardingCloudMonitoringPrepareCreateRequestDeviceVtyAccessListVtyOut
{
	/// <summary>
	/// Name
	/// </summary>
	[DataMember(Name = "name")]
	public string? Name { get; set; }
}