namespace Meraki.Api.Data;

/// <summary>
/// Aggregated voltage readings in volts.
/// </summary>
[DataContract]
public class OrganizationSensorReadingsHistoryByIntervalItemVoltageLevel
{
	/// <summary>
	/// Average voltage reading in volts.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "average")]
	public int Average { get; set; }

	/// <summary>
	/// Maximum voltage reading in volts.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "maximum")]
	public int Maximum { get; set; }

	/// <summary>
	/// Minimum voltage reading in volts.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "minimum")]
	public int Minimum { get; set; }
}