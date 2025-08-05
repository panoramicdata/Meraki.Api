namespace Meraki.Api.Data;

/// <summary>
/// Reading for the 'indoorAirQuality' metric. This will only be present if the 'metric' property equals 'indoorAirQuality'.
/// </summary>
[DataContract]
public class OrganizationsSensorAlertTriggerIndoorAirQuality
{
	/// <summary>
	/// Indoor air quality score between 0 and 100.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "score")]
	public int Score { get; set; }
}