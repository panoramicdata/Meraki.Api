namespace Meraki.Api.Data;

/// <summary>
/// Reading for the 'upstreamPower' metric. This will only be present if the 'metric' property equals 'upstreamPower'.
/// </summary>
[DataContract]
public class OrganizationsSensorAlertTriggerUpstreamPower
{
	/// <summary>
	/// True if an upstream power outage was detected.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "outageDetected")]
	public bool OutageDetected { get; set; }
}