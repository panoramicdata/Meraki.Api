namespace Meraki.Api.Data;

/// <summary>
/// Authentication types
/// </summary>
[DataContract]
public class AuthenticationTypes
{
	/// <summary>
	/// NonEapInnerAuthentication
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "nonEapInnerAuthentication")]
	public List<string> NonEapInnerAuthentication { get; set; } = new();

	/// <summary>
	/// EapInnerAuthentication
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "eapInnerAuthentication")]
	public List<string> EapInnerAuthentication { get; set; } = new();

	/// <summary>
	/// Credentials
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "credentials")]
	public List<string> Credentials { get; set; } = new();

	/// <summary>
	/// TunneledEapMethodCredentials
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "tunneledEapMethodCredentials")]
	public List<string> TunneledEapMethodCredentials { get; set; } = new();
}
