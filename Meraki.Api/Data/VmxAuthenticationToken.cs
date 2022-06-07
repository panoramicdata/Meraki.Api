namespace Meraki.Api.Data;
/// <summary>
/// VMX Authentication Token
/// </summary>
[DataContract]
public class VmxAuthenticationToken
{
	/// <summary>
	/// Authentication Token
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "token")]
	public string Token { get; set; } = string.Empty;

	/// <summary>
	/// Expiry timestamp for the token
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "expiresAt")]
	public DateTime ExpiresAt { get; set; }
}