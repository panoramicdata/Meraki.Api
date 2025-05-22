namespace Meraki.Api.Data;

/// <summary>
/// Limited Access Role
/// </summary>
[DataContract]
public class OrganizationSmAdminsRole
{
	/// <summary>
	/// The name of the limited access role
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// The Id of the limited access role
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "roleId")]
	public string RoleId { get; set; } = string.Empty;

	/// <summary>
	/// The scope of the limited access role. enum = ["all_tags", "some", "without_all_tags", "without_some"]
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "scope")]
	public string Scope { get; set; } = string.Empty;

	/// <summary>
	/// The tags of the limited access role
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "tags")]
	public List<string> Tags { get; set; } = [];
}