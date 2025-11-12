namespace Meraki.Api.Data;

/// <summary>
/// Tags Filter Type
/// </summary>
[DataContract]
[JsonConverter(typeof(StringEnumConverter))]
public enum TagsFilterType
{
	[EnumMember(Value = "withAnyTags")]
	WithAnyTags = 1,

	[EnumMember(Value = "withAllTags")]
	WithAllTags,
}
