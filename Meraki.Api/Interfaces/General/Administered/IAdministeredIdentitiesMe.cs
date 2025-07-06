namespace Meraki.Api.Interfaces.General.Administered;

public interface IAdministeredIdentitiesMe
{
	/// <summary>
	/// Returns the identity of the current user.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getAdministeredIdentitiesMe")]
	[Get("/administered/identities/me")]
	Task<AdministeredIdentitiesMe> GetAdministeredIdentitiesMeAsync(
		CancellationToken cancellationToken = default);
}
