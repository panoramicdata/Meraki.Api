namespace Meraki.Api.Data;

/// <summary>
/// Reading for the 'tvoc' metric. This will only be present if the 'metric' property equals 'tvoc'.
/// </summary>
[DataContract]
public class OrganizationsSensorAlertTriggerTvoc
{
	/// <summary>
	/// TVOC reading in micrograms per cubic meter.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "concentration")]
	public int Concentration { get; set; }
}