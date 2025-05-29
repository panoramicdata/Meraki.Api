namespace Meraki.Api.Data;

/// <summary>
/// Reading for the 'frequency' metric. This will only be present if the 'metric' property equals 'frequency'.
/// </summary>
[DataContract]
public class OrganizationsSensorAlertTriggerFrequency
{
	/// <summary>
	/// Electrical current frequency reading in hertz.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "level")]
	public int Level { get; set; }
}