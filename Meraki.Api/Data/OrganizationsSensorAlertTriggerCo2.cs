namespace Meraki.Api.Data;

/// <summary>
/// Reading for the 'co2' metric. This will only be present if the 'metric' property equals 'co2'.
/// </summary>
[DataContract]
public class OrganizationsSensorAlertTriggerCo2
{
	/// <summary>
	/// CO2 reading in parts per million.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "concentration")]
	public int Concentration { get; set; }
}