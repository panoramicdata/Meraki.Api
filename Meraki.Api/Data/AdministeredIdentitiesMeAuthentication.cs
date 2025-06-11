namespace Meraki.Api.Data;

/// <summary>
/// Authentication info
/// </summary>
[DataContract]
public class AdministeredIdentitiesMeAuthentication
{
	/// <summary>
	/// Authentication mode
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "mode")]
	public string Mode { get; set; } = string.Empty;

	/// <summary>
	/// API authentication
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "api")]
	public AdministeredIdentitiesMeAuthenticationApi Api { get; set; } = new();

	/// <summary>
	/// SAML authentication
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "saml")]
	public AdministeredIdentitiesMeAuthenticationSaml Saml { get; set; } = new();

	/// <summary>
	/// TwoFactor authentication
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "twoFactor")]
	public AdministeredIdentitiesMeAuthenticationTwoFactor TwoFactor { get; set; } = new();
}
