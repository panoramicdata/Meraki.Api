using System;
using System.Collections.Generic;
using System.Text;

namespace Meraki.Api.Data;

/// <summary>
/// Loss percentage
/// </summary>
[DataContract]
public class LiveToolPingResultsLoss
{
	/// <summary>
	/// Percentage
	/// </summary>
	[DataMember(Name = "percentage")]
	public int Percentage { get; set; }
}