namespace Meraki.Api.Data;

/// <summary>
/// API authentication
/// </summary>
[DataContract]
public class AdministeredIdentitiesMeAuthenticationApi
{
	/// <summary>
	/// API key
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "key")]
	public AdministeredIdentitiesMeAuthenticationApiKey Key { get; set; } = new();
}
