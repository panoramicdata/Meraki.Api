namespace Meraki.Api.Data;

/// <summary>
/// UpdateOrganization
/// </summary>
[DataContract]
public class OrganizationUpdateRequest
{
	/// <summary>
	/// The name of the organization
	/// </summary>
	/// <value>The name of the organization</value>
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// API-specific settings
	/// </summary>
	[DataMember(Name = "api")]
	public OrganizationApi Api { get; set; } = new();
}
