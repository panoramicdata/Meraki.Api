namespace Meraki.Api.Data;

/// <summary>
/// Organizations Sensor Alert
/// </summary>
[DataContract]
public class OrganizationsSensorAlert
{
	/// <summary>
	/// The start time of the alert
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "startTs")]
	public string StartTs { get; set; } = string.Empty;

	/// <summary>
	/// The triggered sensor alert profile
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "profile")]
	public OrganizationsSensorAlertProfile Profile { get; set; } = new();

	/// <summary>
	/// The sensor that triggered the alert
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "sensor")]
	public OrganizationsSensorAlertSensor Sensor { get; set; } = new();

	/// <summary>
	/// Camera snapshot information for the alert. If the sensor did not have a camera assigned at the time of the alert, this will be null.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "snapshotCamera")]
	public OrganizationsSensorAlertSnapshotCamera SnapshotCamera { get; set; } = new();

	/// <summary>
	/// The sensor reading that triggered the alert.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "trigger")]
	public OrganizationsSensorAlertTrigger Trigger { get; set; } = new();
}
