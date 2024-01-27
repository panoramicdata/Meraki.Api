namespace Meraki.Api.Data;

/// <summary>
/// Meraki users
/// </summary>
[DataContract]
public class MerakiAuthUser : NamedIdentifiedItem
{
	/// <summary>
	/// Email address of the user
	/// </summary>
	[ApiAccess(ApiAccess.ReadCreate)]
	[DataMember(Name = "email")]
	public string Email { get; set; } = string.Empty;

	/// <summary>
	/// Created at
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "createdAt")]
	public DateTime CreatedAt { get; set; }

	/// <summary>
	/// Authorization type for user. Can be 'Guest' or '802.1X' for wireless networks, or 'Client VPN' for wired networks. Defaults to '802.1X'.
	/// </summary>
	[ApiAccess(ApiAccess.ReadCreate)]
	[DataMember(Name = "accountType")]
	public string AccountType { get; set; } = string.Empty;

	/// <summary>
	/// Whether or not the user is a Dashboard administrator.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "isAdmin")]
	public bool IsAdmin { get; set; }

	/// <summary>
	/// Authorization zones and expiration dates for the user.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "authorizations")]
	public List<Authorization> Authorizations { get; set; } = [];
}
