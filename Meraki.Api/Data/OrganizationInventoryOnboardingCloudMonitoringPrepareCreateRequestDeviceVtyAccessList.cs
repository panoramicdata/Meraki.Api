namespace Meraki.Api.Data;

/// <summary>
/// AccessList details
/// </summary>
[DataContract]
public class OrganizationInventoryOnboardingCloudMonitoringPrepareCreateRequestDeviceVtyAccessList
{
	/// <summary>
	/// VTY  in ACL
	/// </summary>
	[DataMember(Name = "vtyIn")]
	public OrganizationInventoryOnboardingCloudMonitoringPrepareCreateRequestDeviceVtyAccessListVtyIn? VtyIn { get; set; }

	/// <summary>
	/// VTY out ACL
	/// </summary>
	[DataMember(Name = "vtyOut")]
	public OrganizationInventoryOnboardingCloudMonitoringPrepareCreateRequestDeviceVtyAccessListVtyOut? VtyOut { get; set; }
}
