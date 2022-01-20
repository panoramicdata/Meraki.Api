using System;
using System.Collections.Generic;
using System.Text;

namespace Meraki.Api.Data;

[DataContract]

public class ApplianceUtilizationSummaryUtilization
{
	/// <summary>
	/// Average
	/// </summary>
	[DataMember(Name = "average")]
	public ApplianceUtilizationSummaryUtilizationAverage Average { get; set; } = new();
}
