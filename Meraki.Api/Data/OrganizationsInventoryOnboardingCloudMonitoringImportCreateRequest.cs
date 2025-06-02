namespace Meraki.Api.Data;

/// <summary>
/// Organizations Inventory Onboarding Cloud Monitoring Import Create Request
/// </summary>
[DataContract]
public class OrganizationsInventoryOnboardingCloudMonitoringImportCreateRequest
{
	/// <summary>
	/// A set of device imports to commit
	/// </summary>
	[DataMember(Name = "devices")]
	public List<OrganizationsInventoryOnboardingCloudMonitoringImportCreateRequestDevice> Devices { get; set; } = [];
}
