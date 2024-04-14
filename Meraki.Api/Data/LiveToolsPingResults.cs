namespace Meraki.Api.Data;

/// <summary>
/// Results
/// </summary>
[DataContract]
public class LiveToolsPingResults
{
	/// <summary>
	/// Sent
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "sent")]
	public int Sent { get; set; }

	/// <summary>
	/// Received
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "received")]
	public int Received { get; set; }

	/// <summary>
	/// Loss
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "loss")]
	public LiveToolsPingResultsLoss Loss { get; set; } = new();

	/// <summary>
	/// Latencies
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "latencies")]
	public LiveToolsPingResultsLatencies Latencies { get; set; } = new();

	/// <summary>
	/// Replies
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "replies")]
	public List<LiveToolsPingResultsReply> Replies { get; set; } = [];
}
