using System;
using System.Collections.Generic;
using System.Text;

namespace Meraki.Api.Data;

[DataContract]
public class DeviceModelUsageSummaryUsage
{
	/// <summary>
	/// Total
	/// </summary>
	[DataMember(Name = "total")]
	public int Total { get; set; } = 0;

	/// <summary>
	/// Average
	/// </summary>
	[DataMember(Name = "average")]
	public int Average { get; set; } = 0;
}
