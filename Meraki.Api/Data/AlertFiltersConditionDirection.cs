namespace Meraki.Api.Data;

/// <summary>
/// Alert Filters Condition Direction
/// </summary>
[DataContract]
public enum AlertFiltersConditionDirection
{
	[EnumMember(Value = "+")]
	Plus,

	[EnumMember(Value = "-")]
	Minus
}
