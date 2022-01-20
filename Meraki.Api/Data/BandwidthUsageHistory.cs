using System;
using System.Collections.Generic;
using System.Text;

namespace Meraki.Api.Data;

[DataContract]
public class BandwidthUsageHistory
{
	/// <summary>
	/// Ts
	/// </summary>
	[DataMember(Name = "ts")]
	public string Ts { get; set; } = string.Empty;

	/// <summary>
	/// Total
	/// </summary>
	[DataMember(Name = "total")]
	public int Total { get; set; } = 0;

	/// <summary>
	/// Upstream
	/// </summary>
	[DataMember(Name = "upstream")]
	public int Upstream { get; set; } = 0;

	/// <summary>
	/// Downstream
	/// </summary>
	[DataMember(Name = "downstream")]
	public int Downstream { get; set; } = 0;
}
