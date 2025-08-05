namespace Meraki.Api.Data;

/// <summary>
/// Administered Identities Me API Key
/// </summary>
[DataContract]
public class AdministeredIdentitiesMeApiKey
{
	/// <summary>
	/// Date that the API key was created
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "createdAt")]
	public string CreatedAt { get; set; } = string.Empty;

	/// <summary>
	/// Last 4 characters of the API key
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "suffix")]
	public string Suffix { get; set; } = string.Empty;
}
