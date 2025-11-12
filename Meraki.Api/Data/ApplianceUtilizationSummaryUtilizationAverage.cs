namespace Meraki.Api.Data;

/// <summary>
/// Appliance Utilization Summary Utilization Average
/// </summary>
[DataContract]
public class ApplianceUtilizationSummaryUtilizationAverage
{
	/// <summary>
	/// Percentage
	/// </summary>
	[DataMember(Name = "percentage")]
	public double Percentage { get; set; }
}
