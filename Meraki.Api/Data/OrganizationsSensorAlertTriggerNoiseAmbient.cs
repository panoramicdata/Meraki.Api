namespace Meraki.Api.Data;

/// <summary>
/// Ambient noise reading.
/// </summary>
[DataContract]
public class OrganizationsSensorAlertTriggerNoiseAmbient
{
	/// <summary>
	/// Ambient noise reading in adjusted decibels.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "level")]
	public int Level { get; set; }
}