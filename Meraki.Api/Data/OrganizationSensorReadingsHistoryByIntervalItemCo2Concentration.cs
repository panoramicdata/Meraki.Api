namespace Meraki.Api.Data;

/// <summary>
/// Aggregated CO2 readings in parts per million.
/// </summary>
[DataContract]
public class OrganizationSensorReadingsHistoryByIntervalItemCo2Concentration
{
	/// <summary>
	/// Average CO2 reading in parts per million.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "average")]
	public int Average { get; set; }

	/// <summary>
	/// Maximum CO2 reading in parts per million.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "maximum")]
	public int Maximum { get; set; }

	/// <summary>
	/// Minimum CO2 reading in parts per million.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "minimum")]
	public int Minimum { get; set; }
}