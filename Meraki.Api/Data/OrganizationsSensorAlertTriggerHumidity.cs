namespace Meraki.Api.Data;

/// <summary>
/// Reading for the 'humidity' metric. This will only be present if the 'metric' property equals 'humidity'.
/// </summary>
[DataContract]
public class OrganizationsSensorAlertTriggerHumidity
{
	/// <summary>
	/// Humidity reading in %RH.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "relativePercentage")]
	public int RelativePercentage { get; set; }
}