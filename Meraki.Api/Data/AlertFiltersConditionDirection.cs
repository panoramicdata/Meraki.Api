namespace Meraki.Api.Data;

/// <summary>
/// Alert Filters Condition Direction
/// </summary>
[DataContract]
public enum AlertFiltersConditionDirection
{
	[EnumMember(Value = "+")]
	/// <summary>
	/// Plus
	/// </summary>
	Plus,

	[EnumMember(Value = "-")]
	/// <summary>
	/// Minus
	/// </summary>
	Minus
}
