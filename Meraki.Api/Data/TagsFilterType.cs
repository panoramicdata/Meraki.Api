namespace Meraki.Api.Data;

/// <summary>
/// Tags Filter Type
/// </summary>
[DataContract]
[JsonConverter(typeof(StringEnumConverter))]
public enum TagsFilterType
{
	/// <summary>
	/// With Any Tags
	/// </summary>
	[EnumMember(Value = "withAnyTags")]
	WithAnyTags = 1,


	/// <summary>
	/// With All Tags
	/// </summary>
	[EnumMember(Value = "withAllTags")]
	WithAllTags,
}
