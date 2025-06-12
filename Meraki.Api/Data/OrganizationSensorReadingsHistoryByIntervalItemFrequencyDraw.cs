namespace Meraki.Api.Data;

/// <summary>
/// Aggregated electrical current frequency readings in hertz.
/// </summary>
[DataContract]
public class OrganizationSensorReadingsHistoryByIntervalItemFrequencyDraw
{
	/// <summary>
	/// Average electrical current frequency reading in hertz.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "average")]
	public int Average { get; set; }

	/// <summary>
	/// Maximum electrical current frequency reading in hertz.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "maximum")]
	public int Maximum { get; set; }

	/// <summary>
	/// Minimum electrical current frequency reading in hertz.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "minimum")]
	public int Minimum { get; set; }
}