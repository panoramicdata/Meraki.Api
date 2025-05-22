namespace Meraki.Api.Data;

/// <summary>
/// Organizations Sm Admins Role Create Request
/// </summary>
[DataContract]
public class OrganizationSmAdminsRoleCreateRequest
{
	/// <summary>
	/// The name of the Limited Access Role
	/// </summary>
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// The scope of the Limited Access Role. enum = ["all_tags", "some", "without_all_tags", "without_some"]
	/// </summary>
	[DataMember(Name = "scope")]
	public string? Scope { get; set; }

	/// <summary>
	/// The tags of the Limited Access Role
	/// </summary>
	[DataMember(Name = "tags")]
	public List<string>? Tags { get; set; }
}
