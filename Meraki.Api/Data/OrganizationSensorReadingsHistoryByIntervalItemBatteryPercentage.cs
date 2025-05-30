namespace Meraki.Api.Data;

/// <summary>
/// Aggregated battery life readings as a percentage.
/// </summary>
[DataContract]
public class OrganizationSensorReadingsHistoryByIntervalItemBatteryPercentage
{
	/// <summary>
	/// Average battery life reading as a percentage.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "average")]
	public int Average { get; set; }

	/// <summary>
	/// Maximum battery life reading as a percentage.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "maximum")]
	public int Maximum { get; set; }

	/// <summary>
	/// Minimum battery life reading as a percentage.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "minimum")]
	public int Minimum { get; set; }
}