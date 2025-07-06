namespace Meraki.Api.Data;

/// <summary>
/// Jitter summary
/// </summary>
[DataContract]
public class JitterSummary
{
	/// <summary>
	/// Sender uplink
	/// </summary>
	[DataMember(Name = "senderUplink")]
	public string SenderUplink { get; set; } = string.Empty;

	/// <summary>
	/// Receiver uplink
	/// </summary>
	[DataMember(Name = "receiverUplink")]
	public string ReceiverUplink { get; set; } = string.Empty;

	/// <summary>
	/// Average jitter
	/// </summary>
	[DataMember(Name = "avgJitter")]
	public double AvgJitter { get; set; }

	/// <summary>
	/// Minimum jitter
	/// </summary>
	[DataMember(Name = "minJitter")]
	public double MinJitter { get; set; }

	/// <summary>
	/// Maximum jitter
	/// </summary>
	[DataMember(Name = "maxJitter")]
	public double MaxJitter { get; set; }
}
