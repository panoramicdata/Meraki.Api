namespace Meraki.Api.Data;

/// <summary>
/// Alert Filters Condition Direction
/// </summary>
[DataContract]
public enum AlertFiltersConditionDirection
{
	/// <summary>
	/// Plus
	/// </summary>
	[EnumMember(Value = "+")]
	Plus,


	/// <summary>
	/// Minus
	/// </summary>
	[EnumMember(Value = "-")]
	Minus
}
