namespace Meraki.Api.Interfaces.General.Administered;

public interface IAdministeredIdentitiesMeApiKeys
{
	/// <summary>
	/// List the non-sensitive metadata associated with the API keys that belong to the user
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getAdministeredIdentitiesMeApiKeys")]
	[Get("/administered/identities/me/api/keys")]
	Task<List<AdministeredIdentitiesMeApiKey>> GetAdministeredIdentitiesMeApiKeysAsync(
		string organizationId,
		CancellationToken cancellationToken = default
	);
}
