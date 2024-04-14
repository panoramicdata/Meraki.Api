namespace Meraki.Api.Data;

/// <summary>
/// Replies
/// </summary>
[DataContract]
public class LiveToolsPingResultsReply
{
	/// <summary>
	/// Sequence id
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "sequenceId")]
	public int SequenceId { get; set; }

	/// <summary>
	/// Size
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "size")]
	public int Size { get; set; }

	/// <summary>
	/// Latency
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "latency")]
	public int Latency { get; set; }
}
