namespace Meraki.Api.Data;

/// <summary>
/// L7 Application categories
/// </summary>
[DataContract]
public class Layer7ApplicationCategories
{
	/// <summary>
	/// Application categories
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "applicationCategories")]
	public List<ApplicationCategory> ApplicationCategories { get; set; } = new();
}
