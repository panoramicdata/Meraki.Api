namespace Meraki.Api.Data;

/// <summary>
/// SAML authentication 
/// </summary>
[DataContract]
public class AdministeredIdentitiesMeAuthenticationSaml
{
	/// <summary>
	/// If SAML authentication is enabled for this user
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }
}