namespace Meraki.Api.Data;

/// <summary>
/// The parsed VPP service token
/// </summary>
[DataContract]
public class SmVppAccountParsedToken
{
	/// <summary>
	/// The organization name in the token
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "orgName")]
	public string? OrgName { get; set; }

	/// <summary>
	/// The hashed token
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "hashedToken")]
	public string? HashedToken { get; set; }

	/// <summary>
	/// When the token expires
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "expiresAt")]
	public DateTime? ExpiresAt { get; set; }
}
