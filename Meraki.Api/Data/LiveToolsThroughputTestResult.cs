namespace Meraki.Api.Data;

/// <summary>
/// Live Tools Throughput Test Result
/// </summary>
[DataContract]

public class LiveToolsThroughputTestResult
{
	/// <summary>
	/// Shows the speeds in (KB/s)
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "speeds")]
	public LiveToolsThroughputTestResultSpeeds Speeds { get; set; } = new();

}
