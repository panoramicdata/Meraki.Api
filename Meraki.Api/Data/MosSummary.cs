namespace Meraki.Api.Data;

/// <summary>
/// Mos summary
/// </summary>
[DataContract]
public class MosSummary
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
	/// Average mos
	/// </summary>
	[DataMember(Name = "avgMos")]
	public int AvgMos { get; set; }

	/// <summary>
	/// Minimum mos
	/// </summary>
	[DataMember(Name = "minMos")]
	public int MinMos { get; set; }

	/// <summary>
	/// Maximum mos
	/// </summary>
	[DataMember(Name = "maxMos")]
	public int MaxMos { get; set; }
}
