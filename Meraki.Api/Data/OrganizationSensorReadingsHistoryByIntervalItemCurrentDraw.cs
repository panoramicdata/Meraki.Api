namespace Meraki.Api.Data;

/// <summary>
/// Aggregated electrical current readings in amperes.
/// </summary>
[DataContract]
public class OrganizationSensorReadingsHistoryByIntervalItemCurrentDraw
{
	/// <summary>
	/// Average electrical current reading in amperes.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "average")]
	public int Average { get; set; }

	/// <summary>
	/// Maximum electrical current reading in amperes.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "maximum")]
	public int Maximum { get; set; }

	/// <summary>
	/// Minimum electrical current reading in amperes.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "minimum")]
	public int Minimum { get; set; }
}