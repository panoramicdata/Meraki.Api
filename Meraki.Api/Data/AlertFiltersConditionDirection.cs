namespace Meraki.Api.Data;

[DataContract]
public enum AlertFiltersConditionDirection
{
	[EnumMember(Value = "+")]
	Plus,

	[EnumMember(Value = "-")]
	Minus
}