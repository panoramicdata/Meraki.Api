namespace Meraki.Api.Data;

/// <summary>
/// Reading for the 'noise' metric. This will only be present if the 'metric' property equals 'noise'.
/// </summary>
[DataContract]
public class OrganizationsSensorAlertTriggerNoise
{
	/// <summary>
	/// Ambient noise reading.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ambient")]
	public OrganizationsSensorAlertTriggerNoiseAmbient Ambient { get; set; } = new();
}
