using System;
using System.Collections.Generic;
using System.Text;

namespace Meraki.Api.Data;

/// <summary>
/// Latencies
/// </summary>
[DataContract]
public class LiveToolPingResultsLatencies
{
	/// <summary>
	/// Minimum
	/// </summary>
	[DataMember(Name = "minimum")]
	public int Minimum { get; set; }

	/// <summary>
	/// Average
	/// </summary>
	[DataMember(Name = "average")]
	public int Average { get; set; }

	/// <summary>
	/// Maximum
	/// </summary>
	[DataMember(Name = "maximum")]
	public int Maximum { get; set; }
}
