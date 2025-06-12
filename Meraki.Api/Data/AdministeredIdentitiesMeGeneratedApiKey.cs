namespace Meraki.Api.Data;

/// <summary>
/// Administered Identites Me Generated Api Key.
/// </summary>
[DataContract]
public class AdministeredIdentitiesMeGeneratedApiKey
{
	/// <summary>
	/// API key in plaintext. This value will not be accessible outside of key generation
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "key")]
	public string Key { get; set; } = string.Empty;
}
