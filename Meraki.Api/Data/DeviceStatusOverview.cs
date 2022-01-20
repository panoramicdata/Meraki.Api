using System;
using System.Collections.Generic;
using System.Text;

namespace Meraki.Api.Data;

[DataContract]
public class DeviceStatusOverview
{
	/// <summary>
	/// Counts
	/// </summary>
	[DataMember(Name = "counts")]
	public DeviceStatusOverviewCounts Counts { get; set; } = new();
}
