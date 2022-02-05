using System;
using System.Collections.Generic;
using System.Text;

namespace Meraki.Api.Data;

/// <summary>
/// Replies
/// </summary>
[DataContract]
public class LiveToolPingResultsReplies
{
	/// <summary>
	/// Sequence id
	/// </summary>
	[DataMember(Name = "sequenceId")]
	public int SequenceId { get; set; }

	/// <summary>
	/// Size
	/// </summary>
	[DataMember(Name = "size")]
	public int Size { get; set; }

	/// <summary>
	/// Latency
	/// </summary>
	[DataMember(Name = "latency")]
	public int Latency { get; set; }
}
