namespace Meraki.Api.Data;

/// <summary>
/// Aggregated temperature readings in degrees Fahrenheit.
/// </summary>
[DataContract]
public class OrganizationSensorReadingsHistoryByIntervalItemTemperatureFahrenheit
{
	/// <summary>
	/// Average temperature reading in degrees Fahrenheit.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "average")]
	public int Average { get; set; }

	/// <summary>
	/// Maximum temperature reading in degrees Fahrenheit.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "maximum")]
	public int Maximum { get; set; }

	/// <summary>
	/// Minimum temperature reading in degrees Fahrenheit.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "minimum")]
	public int Minimum { get; set; }
}