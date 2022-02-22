namespace Meraki.Api.Data;

/// <summary>
/// UpdateOrganizationAdmin
/// </summary>
[DataContract]
public class AdminUpdateRequest
{
	/// <summary>
	/// The name of the dashboard administrator
	/// </summary>
	[DataMember(Name = "name")]
	public string? Name { get; set; }

	/// <summary>
	/// Gets or Sets OrgAccess
	/// </summary>
	[DataMember(Name = "orgAccess")]
	public OrgAccess OrgAccess { get; set; }

	/// <summary>
	/// The list of tags that the dashboard administrator has privileges on
	/// </summary>
	[DataMember(Name = "tags")]
	public List<AdminTag>? Tags { get; set; }

	/// <summary>
	/// The list of networks that the dashboard administrator has privileges on
	/// </summary>
	[DataMember(Name = "networks")]
	public List<AdminNetworkAccess>? Networks { get; set; }
}
