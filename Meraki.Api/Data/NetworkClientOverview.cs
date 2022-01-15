using System;
using System.Collections.Generic;
using System.Text;

namespace Meraki.Api.Data;

[DataContract]
public class NetworkClientOverview
{
	/// <summary>
	/// Counts
	/// </summary>
	[DataMember(Name = "counts")]
	public NetworkClientOverviewCounts Counts { get; set; } = new();

	/// <summary>
	/// Usages
	/// </summary>
	[DataMember(Name = "counts")]
	public NetworkClientOverviewUsages Usages { get; set; } = new();
}
