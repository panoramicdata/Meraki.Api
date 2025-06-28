namespace Meraki.Api.Data;

/// <summary>
/// Aggregated apparent power readings in volt-amperes.
/// </summary>
[DataContract]
public class OrganizationSensorReadingsHistoryByIntervalItemApparentPowerDraw
{
	/// <summary>
	/// Average apparent power reading in volt-amperes.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "average")]
	public int Average { get; set; }

	/// <summary>
	/// Maximum apparent power reading in volt-amperes.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "maximum")]
	public int Maximum { get; set; }

	/// <summary>
	/// Minimum apparent power reading in volt-amperes.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "minimum")]
	public int Minimum { get; set; }
}