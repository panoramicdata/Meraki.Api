namespace Meraki.Api.Data;

/// <summary>
/// Reading for the 'powerFactor' metric. This will only be present if the 'metric' property equals 'powerFactor'.
/// </summary>
[DataContract]
public class OrganizationsSensorAlertTriggerPowerFactor
{
	/// <summary>
	/// Power factor reading as a percentage.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "percentage")]
	public int Percentage { get; set; }
}