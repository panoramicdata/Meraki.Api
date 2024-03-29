﻿namespace Meraki.Api.Data;

[JsonConverter(typeof(StringEnumConverter))]
public enum FailOverCriterion
{
	/// <summary>
	/// Enum PoorPerformance for "poorPerformance"
	/// </summary>
	[EnumMember(Value = "poorPerformance")]
	PoorPerformance = 1,

	/// <summary>
	/// Enum UplinkDown for "uplinkDown"
	/// </summary>
	[EnumMember(Value = "uplinkDown")]
	UplinkDown,
}
