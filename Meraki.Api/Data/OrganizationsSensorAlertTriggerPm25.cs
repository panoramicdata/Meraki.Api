namespace Meraki.Api.Data;

/// <summary>
/// Reading for the 'pm25' metric. This will only be present if the 'metric' property equals 'pm25'.
/// </summary>
[DataContract]
public class OrganizationsSensorAlertTriggerPm25
{
	/// <summary>
	/// PM2.5 reading in micrograms per cubic meter.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "concentration")]
	public int Concentration { get; set; }
}