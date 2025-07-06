namespace Meraki.Api.Data;

/// <summary>
/// Organization Inventory Onboarding Cloud Monitoring Prepare Item
/// </summary>
[DataContract]
public class OrganizationInventoryOnboardingCloudMonitoringPrepareItem
{
	/// <summary>
	/// Import ID from the Import operation
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "deviceId")]
	public string DeviceId { get; set; } = string.Empty;

	/// <summary>
	/// Message related to whether or not the device was found and can be imported.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "message")]
	public string Message { get; set; } = string.Empty;

	/// <summary>
	/// The import status of the device
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;

	/// <summary>
	/// Device UDI certificate
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "udi")]
	public string Udi { get; set; } = string.Empty;

	/// <summary>
	/// Params used in order to connect to the device
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "configParams")]
	public OrganizationInventoryOnboardingCloudMonitoringPrepareItemConfigParams ConfigParams { get; set; } = new();
}
