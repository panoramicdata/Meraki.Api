namespace Meraki.Api.Data;

/// <summary>
/// Aggregated power factor readings as a percentage.
/// </summary>
[DataContract]
public class OrganizationSensorReadingsHistoryByIntervalItemPowerFactorPercentage
{
	/// <summary>
	/// Average power factor reading as a percentage.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "average")]
	public int Average { get; set; }

	/// <summary>
	/// Maximum power factor reading as a percentage.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "maximum")]
	public int Maximum { get; set; }

	/// <summary>
	/// Minimum power factor reading as a percentage.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "minimum")]
	public int Minimum { get; set; }
}