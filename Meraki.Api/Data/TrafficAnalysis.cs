namespace Meraki.Api.Data;

/// <summary>
/// UpdateNetworkTrafficAnalysisSettings
/// </summary>
[DataContract]
public class TrafficAnalysis
{
	/// <summary>
	/// Gets or Sets Mode
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "mode")]
	public TrafficAnalysisMode Mode { get; set; }
	/// <summary>
	/// The list of items that make up the custom pie chart for traffic reporting.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "customPieChartItems")]
	public List<CustomPieChartItem> CustomPieChartItems { get; set; } = new();
}
