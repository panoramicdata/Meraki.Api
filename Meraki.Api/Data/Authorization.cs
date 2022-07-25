namespace Meraki.Api.Data;

/// <summary>
/// Authorizations
/// </summary>
[DataContract]
public class Authorization
{
	/// <summary>
	/// SSID for which the user is being authorized
	/// </summary>
	[ApiAccess(ApiAccess.CreateUpdate)]
	[DataMember(Name = "ssidNumber")]
	public int SsidNumber { get; set; }

	/// <summary>
	/// Authorized zone
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "authorizedZone")]
	public string AuthorizedZone { get; set; } = string.Empty;

	/// <summary>
	/// Date for authorization to expire. Set to 'Never' for the authorization to not expire, which is the default.
	/// </summary>
	[ApiAccess(ApiAccess.CreateUpdate)]
	[DataMember(Name = "expiresAt")]
	public string ExpiresAt { get; set; } = string.Empty; // This must be a string as can be 'Never'

	/// <summary>
	/// Authorized by name
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "authorizedByName")]
	public string AuthorizedByName { get; set; } = string.Empty;

	/// <summary>
	/// Authorized by email
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "authorizedByEmail")]
	public string authorizedByEmail { get; set; } = string.Empty;
}
