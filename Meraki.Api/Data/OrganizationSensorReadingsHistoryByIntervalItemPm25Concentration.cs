namespace Meraki.Api.Data;

/// <summary>
/// Aggregated PM2.5 readings in micrograms per cubic meter.
/// </summary>
[DataContract]
public class OrganizationSensorReadingsHistoryByIntervalItemPm25Concentration
{
	/// <summary>
	/// Average PM2.5 reading in micrograms per cubic meter.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "average")]
	public int Average { get; set; }

	/// <summary>
	/// Maximum PM2.5 reading in micrograms per cubic meter.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "maximum")]
	public int Maximum { get; set; }

	/// <summary>
	/// Minimum PM2.5 reading in micrograms per cubic meter.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "minimum")]
	public int Minimum { get; set; }
}