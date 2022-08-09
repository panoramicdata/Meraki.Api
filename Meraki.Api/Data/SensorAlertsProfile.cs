namespace Meraki.Api.Data;

/// <summary>
/// Sensor alerts profile for a network
/// </summary>
[DataContract]
public class SensorAlertsProfile : NamedItem
{
	///<summary>
	///Id of the Sensor Alert Profile
	/// </summary>
	[ApiKey]
	[DataMember(Name = "profileId")]
	public string ProfileId { get; set; } = string.Empty;

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