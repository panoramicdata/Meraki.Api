namespace Meraki.Api.Data;

/// <summary>
/// Aggregated ambient noise readings in adjusted decibels.
/// </summary>
[DataContract]
public class OrganizationSensorReadingsHistoryByIntervalItemNoiseAmbientLevel
{
	/// <summary>
	/// Average ambient noise reading in adjusted decibels.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "average")]
	public int Average { get; set; }

	/// <summary>
	/// Maximum ambient noise reading in adjusted decibels.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "maximum")]
	public int Maximum { get; set; }

	/// <summary>
	/// Minimum ambient noise reading in adjusted decibels.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "minimum")]
	public int Minimum { get; set; }
}