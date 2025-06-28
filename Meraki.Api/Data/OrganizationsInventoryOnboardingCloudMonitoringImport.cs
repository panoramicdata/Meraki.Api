namespace Meraki.Api.Data;

/// <summary>
/// Organizations Inventory Onboarding Cloud Monitoring Import
/// </summary>
[DataContract]
public class OrganizationsInventoryOnboardingCloudMonitoringImport
{
	/// <summary>
	/// Database ID for the new entity entry.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "importId")]
	public string ImportId { get; set; } = string.Empty;

	/// <summary>
	/// Represents the details of an imported device.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "device")]
	public OrganizationsInventoryOnboardingCloudMonitoringImportDevice Device { get; set; } = new();
}
