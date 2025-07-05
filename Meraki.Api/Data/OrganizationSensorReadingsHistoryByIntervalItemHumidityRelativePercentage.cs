namespace Meraki.Api.Data;

/// <summary>
/// Aggregated humidity readings in %RH.
/// </summary>
[DataContract]
public class OrganizationSensorReadingsHistoryByIntervalItemHumidityRelativePercentage
{
	/// <summary>
	/// Average humidity reading in %RH.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "average")]
	public int Average { get; set; }

	/// <summary>
	/// Maximum humidity reading in %RH.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "maximum")]
	public int Maximum { get; set; }

	/// <summary>
	/// Minimum humidity reading in %RH.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "minimum")]
	public int Minimum { get; set; }
}