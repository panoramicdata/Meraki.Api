namespace Meraki.Api.Data;

/// <summary>
/// Organization Assurance Alerts Taxonomy Category
/// </summary>
[DataContract]
public class OrganizationAssuranceAlertsTaxonomyCategory
{
	/// <summary>
	/// Category title
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "title")]
	public string Title { get; set; } = string.Empty;

	/// <summary>
	/// Category type
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "type")]
	public string Type { get; set; } = string.Empty;
}
