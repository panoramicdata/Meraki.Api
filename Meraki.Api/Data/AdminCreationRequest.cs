namespace Meraki.Api.Data;

/// <summary>
/// CreateOrganizationAdmin
/// </summary>
[DataContract]
public class AdminCreationRequest
{
	/// <summary>
	/// The email of the dashboard administrator. This attribute can not be updated.
	/// </summary>
	[DataMember(Name = "email")]
	public string Email { get; set; } = null!;

	/// <summary>
	/// The method of authentication the user will use to sign in to the Meraki dashboard. Can be one of 'Email' or 'Cisco SecureX Sign-On'. The default is Email authentication
	/// </summary>
	[DataMember(Name = "authenticationMethod")]
	public string AuthenticationMethod { get; set; } = string.Empty;

	/// <summary>
	/// The name of the dashboard administrator
	/// </summary>
	[DataMember(Name = "name")]
	public string Name { get; set; } = null!;

	/// <summary>
	/// Gets or Sets OrgAccess
	/// </summary>
	[DataMember(Name = "orgAccess")]
	public OrgAccess OrgAccess { get; set; }

	/// <summary>
	/// The list of tags that the dashboard administrator has privileges on
	/// </summary>
	[DataMember(Name = "tags")]
	public List<AdminTag> Tags { get; set; } = null!;

	/// <summary>
	/// The list of networks that the dashboard administrator has privileges on
	/// </summary>
	[DataMember(Name = "networks")]
	public List<AdminNetworkAccess> Networks { get; set; } = null!;
}
