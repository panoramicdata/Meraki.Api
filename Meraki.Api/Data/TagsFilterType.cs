namespace Meraki.Api.Data;

[DataContract]
[JsonConverter(typeof(StringEnumConverter))]
public enum TagsFilterType
{
	[EnumMember(Value = "withAnyTags")]
	WithAnyTags = 1,

	[EnumMember(Value = "withAllTags")]
	WithAllTags,
}