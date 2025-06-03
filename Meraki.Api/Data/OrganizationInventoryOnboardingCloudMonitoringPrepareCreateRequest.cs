namespace Meraki.Api.Data;

/// <summary>
/// Organization Inventory Onboarding Cloud Monitoring Prepare Create Request
/// </summary>
[DataContract]
public class OrganizationInventoryOnboardingCloudMonitoringPrepareCreateRequest
{
	/// <summary>
	/// Additional options for the import
	/// </summary>
	[DataMember(Name = "options")]
	public OrganizationInventoryOnboardingCloudMonitoringPrepareCreateRequestOptions? Options { get; set; }

	/// <summary>
	/// A set of devices to import (or update)
	/// </summary>
	[DataMember(Name = "devices")]
	public List<OrganizationInventoryOnboardingCloudMonitoringPrepareCreateRequestDevice> Devices { get; set; } = [];
}
