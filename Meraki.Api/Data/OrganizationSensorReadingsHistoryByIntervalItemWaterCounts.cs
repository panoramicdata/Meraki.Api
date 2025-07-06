namespace Meraki.Api.Data;

/// <summary>
/// Accumulated counts of water detection readings.
/// </summary>
[DataContract]
public class OrganizationSensorReadingsHistoryByIntervalItemWaterCounts
{
	/// <summary>
	/// Number of times that water was detected.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "present")]
	public int Present { get; set; }
}