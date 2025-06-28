namespace Meraki.Api.Data;

/// <summary>
/// Aggregated real power readings in watts.
/// </summary>
[DataContract]
public class OrganizationSensorReadingsHistoryByIntervalItemRealPowerDraw
{
	/// <summary>
	/// Average real power reading in watts.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "average")]
	public int Average { get; set; }

	/// <summary>
	/// Maximum real power reading in watts.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "maximum")]
	public int Maximum { get; set; }

	/// <summary>
	/// Minimum real power reading in watts.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "minimum")]
	public int Minimum { get; set; }
}