﻿namespace Meraki.Api.Data;

/// <summary>
/// Loss percentage summary
/// </summary>
[DataContract]
public class LossPercentageSummary
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
	/// Average loss percentage
	/// </summary>
	[DataMember(Name = "avgLossPercentage")]
	public double AvgLossPercentage { get; set; }

	/// <summary>
	/// Minimum loss percentage
	/// </summary>
	[DataMember(Name = "minLossPercentage")]
	public double MinLossPercentage { get; set; }

	/// <summary>
	/// Maximum loss percentage
	/// </summary>
	[DataMember(Name = "maxLossPercentage")]
	public double MaxLossPercentage { get; set; }
}
