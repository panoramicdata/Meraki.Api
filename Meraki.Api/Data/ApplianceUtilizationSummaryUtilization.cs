namespace Meraki.Api.Data;

/// <summary>
/// Appliance Utilization Summary Utilization
/// </summary>
[DataContract]

public class ApplianceUtilizationSummaryUtilization
{
	/// <summary>
	/// Average
	/// </summary>
	[DataMember(Name = "average")]
	public ApplianceUtilizationSummaryUtilizationAverage Average { get; set; } = new();
}
