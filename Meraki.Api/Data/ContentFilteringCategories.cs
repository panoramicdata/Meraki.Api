namespace Meraki.Api.Data;

/// <summary>
/// Content filtering catergories
/// </summary>
[DataContract]
public class ContentFilteringCategories
{
	/// <summary>
	/// Categories
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "categories")]
	public List<ContentFilteringCategory> Categories { get; set; } = new();
}
