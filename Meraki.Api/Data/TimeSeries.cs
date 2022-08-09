﻿namespace Meraki.Api.Data;

/// <summary>
/// Time series
/// </summary>
[DataContract]
public class TimeSeries
{
	/// <summary>
	/// Ts
	/// </summary>
	[DataMember(Name = "ts")]
	public string Ts { get; set; } = string.Empty;

	/// <summary>
	/// Loss percent
	/// </summary>
	[DataMember(Name = "lossPercent")]
	public double LossPercent { get; set; }

	/// <summary>
	/// Latency ms
	/// </summary>
	[DataMember(Name = "latencyMs")]
	public double LatencyMs { get; set; }
}
