namespace Meraki.Api.Data;

/// <summary>
/// Live Tools Throughput Test Create Response Result
/// </summary>
[DataContract]

public class LiveToolsThroughputTestCreateResponseResult
{
	/// <summary>
	/// Shows the speeds in (KB/s)
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "speeds")]
	public LiveToolsThroughputTestCreateResponseResultSpeeds Speeds { get; set; } = new();
}
