namespace Meraki.Api.Data;

/// <summary>
/// The current setting for Active Directory. Only valid if splashPage is 'Password-protected with Active Directory'
/// </summary>
[DataContract]
public class ActiveDirectory
{
	/// <summary>
	/// (Optional) The credentials of the user account to be used by the AP to bind to your Active Directory server. The Active Directory account should have permissions on all your Active Directory servers. Only valid if the splashPage is 'Password-protected with Active Directory'.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "credentials")]
	public ActiveDirectoryCredentials? Credentials { get; set; }

	/// <summary>
	/// The Active Directory servers to be used for authentication.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "servers")]
	public List<ActiveDirectoryServer> Servers { get; set; } = new();
}
