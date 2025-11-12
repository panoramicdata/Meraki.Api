namespace Meraki.Api.Data;

/// <summary>
/// Network Client Overview Usages
/// </summary>
[DataContract]
public class NetworkClientOverviewUsages
{
	/// <summary>
	/// Average
	/// </summary>
	[DataMember(Name = "average")]
	public int Average { get; set; }

	/// <summary>
	/// With heavy usage average
	/// </summary>
	[DataMember(Name = "withHeavyUsageAverage")]
	public int WithHeavyUsageAverage { get; set; }
}
