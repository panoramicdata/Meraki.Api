﻿namespace Meraki.Api.Data;
/// <summary>
/// Counts
/// </summary>
[DataContract]

public class StackDeviceSwitchPortsCounts
{
	/// <summary>
	/// By status
	/// </summary>
	[DataMember(Name = "byStatus")]
	public StackDeviceSwitchPortsCountsByStatus ByStatus { get; set; } = new();
}
