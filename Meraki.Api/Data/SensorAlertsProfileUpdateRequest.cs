namespace Meraki.Api.Data;

/// <summary>
/// Update request for a sensor alerts profile for a network
/// </summary>
[DataContract]
public class SensorAlertsProfileUpdateRequest : NamedIdentifiedItem
{
	///<summary>
	/// Include dashboard link to sensor in messages (default: true).
	/// </summary>
	[ApiKey]
	[DataMember(Name = "includeSensorUrl")]
	public bool? IncludeSensorUrl { get; set; }

	///<summary>
	/// A custom message that will appear in email and text message alerts.
	/// </summary>
	[ApiKey]
	[DataMember(Name = "message")]
	public string? Message { get; set; }

	/// <summary>
	/// List of device serials assigned to this sensor profile
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serials")]
	public List<string>? Serials { get; set; }

	/// <summary>
	/// Sensor alerts profile recipients
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "recipients")]
	public SensorAlertsProfileRecipients? Recipients { get; set; }

	/// <summary>
	/// Sensor alerts profile schedule
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "schedule")]
	public SensorAlertsProfileSchedule? Schedule { get; set; }

	/// <summary>
	/// Sensor alert conditions
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "conditions")]
	public List<SensorAlertProfileCondition>? Conditions { get; set; }
}