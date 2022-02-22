namespace Meraki.Api.Data;

/// <summary>
/// An administrator
/// </summary>
[DataContract]
public class Admin : NamedIdentifiedItem
{
	/// <summary>
	/// The administrator's Email
	/// </summary>
	[ApiAccess(ApiAccess.ReadCreate)]
	[DataMember(Name = "email")]
	public string Email { get; set; } = string.Empty;

	/// <summary>
	/// The administrator's organization Access
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "orgAccess")]
	public OrgAccess OrganizationAccess { get; set; }

	/// <summary>
	/// Account status
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "accountStatus")]
	public string AccountStatus { get; set; } = string.Empty;

	/// <summary>
	/// Whether two factor authorization is enabled
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "twoFactorAuthEnabled")]
	public bool TwoFactorAuthEnabled { get; set; }

	/// <summary>
	/// Whether the administrator has an API key
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "hasApiKey")]
	public bool HasApiKey { get; set; }

	/// <summary>
	/// Last active
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "lastActive")]
	public DateTime LastActive { get; set; }

	/// <summary>
	/// The list of tags that the dashboard administrator has privileges on
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "tags")]
	public List<AdminTag> Tags { get; set; } = new List<AdminTag>();

	/// <summary>
	/// The list of networks that the dashboard administrator has privileges on
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "networks")]
	public List<AdminNetworkAccess> Networks { get; set; } = new List<AdminNetworkAccess>();

	/// <summary>
	/// The method of authentication the user will use to sign in to the Meraki dashboard. Can be one of 'Email' or 'Cisco SecureX Sign-On'. The default is Email authentication
	/// </summary>
	[ApiAccess(ApiAccess.ReadCreate)]
	[DataMember(Name = "authenticationMethod")]
	public string AuthenticationMethod { get; set; } = string.Empty;
}
