namespace Meraki.Api.Interfaces.General.Administered;

/// <summary>
/// I Administered Identities Me Api Keys
/// </summary>
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

	/// <summary>
	/// Generates an API key for an identity. For users who have access to more than one organization, the change will take up to five minutes to propagate. If one of the organizations is currently under maintenance, the change may not propagate fully until after the maintenance has been completed.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("generateAdministeredIdentitiesMeApiKeys")]
	[Post("/administered/identities/me/api/keys/generate")]
	Task<AdministeredIdentitiesMeGeneratedApiKey> GenerateAdministeredIdentitiesMeApiKeysAsync(
		string organizationId,
		CancellationToken cancellationToken = default
	);

	/// <summary>
	/// Revokes an identity's API key, using the last four characters of the key. For users who have access to more than one organization, the change will take up to five minutes to propagate. If one of the organizations is currently under maintenance, the change may not propagate fully until after the maintenance has been completed.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="suffix"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("revokeAdministeredIdentitiesMeApiKeys")]
	[Post("/administered/identities/me/api/keys/{suffix}/revoke")]
	Task RevokeAdministeredIdentitiesMeApiKeysAsync(
		string organizationId,
		string suffix,
		CancellationToken cancellationToken = default
	);
}
