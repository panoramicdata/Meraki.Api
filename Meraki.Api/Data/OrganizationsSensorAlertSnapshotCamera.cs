namespace Meraki.Api.Data;

/// <summary>
/// Camera snapshot information for the alert. If the sensor did not have a camera assigned at the time of the alert, this will be null.
/// </summary>
[DataContract]
public class OrganizationsSensorAlertSnapshotCamera
{
	/// <summary>
	/// Name of the camera
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Serial number of the camera
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// URL to the camera
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "url")]
	public string Url { get; set; } = string.Empty;

}