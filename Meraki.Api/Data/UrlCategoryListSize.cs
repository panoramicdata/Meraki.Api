namespace Meraki.Api.Data;

/// <summary>
/// URL category list size which is either 'topSites' or 'fullList'
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum UrlCategoryListSize
{
	/// <summary>
	/// Enum TopSites for "topSites"
	/// </summary>
	[EnumMember(Value = "topSites")]
	TopSites = 1,

	/// <summary>
	/// Enum FullList for "fullList"
	/// </summary>
	[EnumMember(Value = "fullList")]
	FullList
}
