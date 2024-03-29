namespace Meraki.Api.Data;

/// <summary>
/// CreateOrganization
/// </summary>
[DataContract]
public class OrganizationCreateRequest
{
	/// <summary>
	/// The name of the organization
	/// </summary>
	/// <value>The name of the organization</value>
	[DataMember(Name = "name")]
	public string Name { get; set; } = null!;
}
