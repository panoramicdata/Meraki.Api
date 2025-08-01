﻿namespace Meraki.Api.Data;

/// <summary>
/// performance information
/// </summary>
[DataContract]
public class WirelessHealthScoresPerformance
{
	/// <summary>
	/// device performance score
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "latest")]
	public int Latest { get; set; }
}