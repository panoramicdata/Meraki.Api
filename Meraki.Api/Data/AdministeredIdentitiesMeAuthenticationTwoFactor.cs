namespace Meraki.Api.Data;

/// <summary>
/// TwoFactor authentication
/// </summary>
[DataContract]
public class AdministeredIdentitiesMeAuthenticationTwoFactor
{
	/// <summary>
	/// If twoFactor authentication is enabled for this user
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }
}