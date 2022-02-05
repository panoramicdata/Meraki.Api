using System;
using System.Collections.Generic;
using System.Text;

namespace Meraki.Api.Data;

/// <summary>
/// Results
/// </summary>
[DataContract]
public class LiveToolPingResults
{
	/// <summary>
	/// Sent
	/// </summary>
	[DataMember(Name = "sent")]
	public int Sent { get; set; }

	/// <summary>
	/// Received
	/// </summary>
	[DataMember(Name = "received")]
	public int Received { get; set; }

	/// <summary>
	/// Loss
	/// </summary>
	[DataMember(Name = "loss")]
	public LiveToolPingResultsLoss Loss { get; set; } = new();

	/// <summary>
	/// Latencies
	/// </summary>
	[DataMember(Name = "latencies")]
	public LiveToolPingResultsLatencies Latencies { get; set; } = new();

	/// <summary>
	/// Replies
	/// </summary>
	[DataMember(Name = "replies")]
	public List<LiveToolPingResultsReplies> Replies { get; set; } = new();
}
