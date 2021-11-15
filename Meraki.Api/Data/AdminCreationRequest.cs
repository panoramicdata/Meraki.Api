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
	/// <value>The email of the dashboard administrator. This attribute can not be updated.</value>
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
	/// <value>The name of the dashboard administrator</value>
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
	/// <value>The list of tags that the dashboard administrator has privileges on</value>
	[DataMember(Name = "tags")]
	public List<Tag> Tags { get; set; } = null!;

	/// <summary>
	/// The list of networks that the dashboard administrator has privileges on
	/// </summary>
	/// <value>The list of networks that the dashboard administrator has privileges on</value>
	[DataMember(Name = "networks")]
	public List<Network> Networks { get; set; } = null!;
}
