namespace Meraki.Api.Data;

/// <summary>
/// Represents the details of an imported device.
/// </summary>
[DataContract]
public class OrganizationsInventoryOnboardingCloudMonitoringImportDevice
{
	/// <summary>
	/// Represents the current state of importing the device.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;

	/// <summary>
	/// The url to the device details page within dashboard.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "url")]
	public string Url { get; set; } = string.Empty;

	/// <summary>
	/// Whether or not the device was successfully created in dashboard.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "created")]
	public bool Created { get; set; }
}