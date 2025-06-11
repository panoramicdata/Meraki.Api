namespace Meraki.Api.Data;

/// <summary>
/// API key
/// </summary>
[DataContract]
public class AdministeredIdentitiesMeAuthenticationApiKey
{
	/// <summary>
	/// If API key is created for this user
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "created")]
	public bool Created { get; set; }
}