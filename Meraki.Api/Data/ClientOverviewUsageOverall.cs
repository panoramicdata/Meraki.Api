using System;
using System.Collections.Generic;
using System.Text;

namespace Meraki.Api.Data;

[DataContract]
public class ClientOverviewUsageOverall
{
	/// <summary>
	/// Total
	/// </summary>
	[DataMember(Name = "total")]
	public int Total { get; set; } = 0;

	/// <summary>
	/// Downstream
	/// </summary>
	[DataMember(Name = "downstream")]
	public int Downstream { get; set; } = 0;

	/// <summary>
	/// Upstream
	/// </summary>
	[DataMember(Name = "upstream")]
	public int Upstream { get; set; } = 0;

	/// <summary>
	/// Percentage
	/// </summary>
	[DataMember(Name = "percentage")]
	public int Percentage { get; set; } = 0;
}
