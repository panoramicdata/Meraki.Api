namespace Meraki.Api.Data;

/// <summary>
/// Tags Filter Type
/// </summary>
[DataContract]
[JsonConverter(typeof(StringEnumConverter))]
public enum TagsFilterType
{
	[EnumMember(Value = "withAnyTags")]
	/// <summary>
	/// With Any Tags
	/// </summary>
	WithAnyTags = 1,

	[EnumMember(Value = "withAllTags")]
	/// <summary>
	/// With All Tags
	/// </summary>
	WithAllTags,
}
