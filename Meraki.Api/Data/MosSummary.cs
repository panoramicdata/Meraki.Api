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
	public double AvgMos { get; set; }

	/// <summary>
	/// Minimum mos
	/// </summary>
	[DataMember(Name = "minMos")]
	public double MinMos { get; set; }

	/// <summary>
	/// Maximum mos
	/// </summary>
	[DataMember(Name = "maxMos")]
	public double MaxMos { get; set; }
}
