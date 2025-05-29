namespace Meraki.Api.Data;

/// <summary>
/// Reading for the 'apparentPower' metric. This will only be present if the 'metric' property equals 'apparentPower'.
/// </summary>
[DataContract]
public class OrganizationsSensorAlertTriggerApparentPower
{
	/// <summary>
	/// Apparent power reading in volt-amperes.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "draw")]
	public int Draw { get; set; }
}