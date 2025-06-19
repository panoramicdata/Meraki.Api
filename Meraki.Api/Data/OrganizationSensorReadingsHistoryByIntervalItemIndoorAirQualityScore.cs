namespace Meraki.Api.Data;

/// <summary>
/// Aggregated indoor air quality readings as a score between 0-100.
/// </summary>
[DataContract]
public class OrganizationSensorReadingsHistoryByIntervalItemIndoorAirQualityScore
{
	/// <summary>
	/// Average indoor air quality reading as a score between 0-100.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "average")]
	public int Average { get; set; }

	/// <summary>
	/// Maximum indoor air quality reading as a score between 0-100.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "maximum")]
	public int Maximum { get; set; }

	/// <summary>
	/// Minimum indoor air quality reading as a score between 0-100.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "minimum")]
	public int Minimum { get; set; }
}