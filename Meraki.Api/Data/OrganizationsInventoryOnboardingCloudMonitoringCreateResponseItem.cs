namespace Meraki.Api.Data;

/// <summary>
/// Organizations Inventory Onboarding Cloud Monitoring Create Response Item
/// </summary>
[DataContract]
public class OrganizationsInventoryOnboardingCloudMonitoringCreateResponseItem
{
	/// <summary>
	/// Unique id associated with the import of the device
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "importId")]
	public string ImportId { get; set; } = string.Empty;

	/// <summary>
	/// Response method
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "message")]
	public string Message { get; set; } = string.Empty;

	/// <summary>
	/// Cloud monitor import status
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;
}
