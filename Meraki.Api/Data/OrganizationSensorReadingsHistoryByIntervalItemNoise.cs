namespace Meraki.Api.Data;

/// <summary>
/// Reading information over the interval for the 'noise' metric. This will only be present if the 'metric' property equals 'noise'.
/// </summary>
[DataContract]
public class OrganizationSensorReadingsHistoryByIntervalItemNoise
{
	/// <summary>
	/// Ambient noise reading.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ambient")]
	public OrganizationSensorReadingsHistoryByIntervalItemNoiseAmbient Ambient { get; set; } = new();
}
