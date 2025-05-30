namespace Meraki.Api.Data;

/// <summary>
/// Reading information over the interval for the 'energy' metric. This will only be present if the 'metric' property equals 'energy'.
/// </summary>
[DataContract]
public class OrganizationSensorReadingsHistoryByIntervalItemEnergy
{
	/// <summary>
	/// Energy usage over the time interval in kilowatt-hours.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "usage")]
	public int Usage { get; set; }
}