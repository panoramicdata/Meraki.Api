namespace Meraki.Api.Data;

/// <summary>
/// Client Overview Usage Overall
/// </summary>
[DataContract]
public class ClientOverviewUsageOverall
{
	/// <summary>
	/// Total
	/// </summary>
	[DataMember(Name = "total")]
	public double Total { get; set; }

	/// <summary>
	/// Downstream
	/// </summary>
	[DataMember(Name = "downstream")]
	public double Downstream { get; set; }

	/// <summary>
	/// Upstream
	/// </summary>
	[DataMember(Name = "upstream")]
	public double Upstream { get; set; }

	/// <summary>
	/// Percentage
	/// </summary>
	[DataMember(Name = "percentage")]
	public double Percentage { get; set; }
}
