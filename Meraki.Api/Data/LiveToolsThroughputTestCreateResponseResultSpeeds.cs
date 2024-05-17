namespace Meraki.Api.Data;

/// <summary>
/// Live Tools Throughput Test Create Response Result Speeds
/// </summary>
[DataContract]

public class LiveToolsThroughputTestCreateResponseResultSpeeds
{
	/// <summary>
	/// Shows the speeds in (KB/s)
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "downstream")]
	public double Downstream { get; set; }
}
