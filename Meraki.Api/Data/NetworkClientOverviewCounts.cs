using System;
using System.Collections.Generic;
using System.Text;

namespace Meraki.Api.Data;

[DataContract]
public class NetworkClientOverviewCounts
{
	/// <summary>
	/// Total
	/// </summary>
	[DataMember(Name = "total")]
	public int Total { get; set; } = 0;

	/// <summary>
	/// With heavy usage
	/// </summary>
	[DataMember(Name = "withHeavyUsage")]
	public int WithHeavyUsage { get; set; } = 0;
}
