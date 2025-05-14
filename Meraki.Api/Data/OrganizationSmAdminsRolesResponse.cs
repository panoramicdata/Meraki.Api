namespace Meraki.Api.Data;

/// <summary>
/// Organizations Sm Admins Roles Response
/// </summary>
[DataContract]
public class OrganizationSmAdminsRolesResponse
{
	/// <summary>
	/// Metadata relevant to the paginated dataset
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "meta")]
	public OrganizationSmAdminsRolesMetadata Meta { get; set; } = new();

	/// <summary>
	/// Array of Limited Access Roles
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "items")]
	public List<OrganizationSmAdminsRole> Items { get; set; } = [];
}
