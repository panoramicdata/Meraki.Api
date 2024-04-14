namespace Meraki.Api.Data;

/// <summary>
/// Latencies
/// </summary>
[DataContract]
public class LiveToolsPingResultsLatencies
{
	/// <summary>
	/// Minimum
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "minimum")]
	public int Minimum { get; set; }

	/// <summary>
	/// Average
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "average")]
	public int Average { get; set; }

	/// <summary>
	/// Maximum
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "maximum")]
	public int Maximum { get; set; }
}
