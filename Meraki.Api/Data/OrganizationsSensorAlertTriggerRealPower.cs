namespace Meraki.Api.Data;

/// <summary>
/// Reading for the 'realPower' metric. This will only be present if the 'metric' property equals 'realPower'.
/// </summary>
[DataContract]
public class OrganizationsSensorAlertTriggerRealPower
{
	/// <summary>
	/// Real power reading in watts.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "draw")]
	public int Draw { get; set; }
}