namespace Meraki.Api.Data;

/// <summary>
/// Swap Status
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum SwapStatus
{
	/// <summary>
	/// Complete
	/// </summary>
	[EnumMember(Value = "complete")]
	Complete,

	/// <summary>
	/// Failed
	/// </summary>
	[EnumMember(Value = "failed")]
	Failed,

	/// <summary>
	/// Pending
	/// </summary>
	[EnumMember(Value = "pending")]
	Pending
}