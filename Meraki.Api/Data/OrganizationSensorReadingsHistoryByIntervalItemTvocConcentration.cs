namespace Meraki.Api.Data;

/// <summary>
/// Aggregated TVOC readings in micrograms per cubic meter.
/// </summary>
[DataContract]
public class OrganizationSensorReadingsHistoryByIntervalItemTvocConcentration
{
	/// <summary>
	/// Average TVOC reading in micrograms per cubic meter.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "average")]
	public int Average { get; set; }

	/// <summary>
	/// Maximum TVOC reading in micrograms per cubic meter.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "maximum")]
	public int Maximum { get; set; }

	/// <summary>
	/// Minimum TVOC reading in micrograms per cubic meter.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "minimum")]
	public int Minimum { get; set; }
}