namespace Meraki.Api.Interfaces.General.Organizations;

/// <summary>
/// Interface for Push API Receiver Profiles
/// </summary>
public interface IOrganizationsApiPushReceiversProfiles
{
	/// <summary>
	/// List Push API receiver profiles for an organization
	/// GET /organizations/{organizationId}/api/push/receivers/profiles
	/// </summary>
	/// <param name="organizationId">The organization ID</param>
	/// <param name="cancellationToken">The cancellation token</param>
	[Get("/organizations/{organizationId}/api/push/receivers/profiles")]
	Task<PushReceiverProfilesResponse> GetOrganizationApiPushReceiversProfilesAsync(
		string organizationId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Create a Push API receiver profile
	/// POST /organizations/{organizationId}/api/push/receivers/profiles
	/// </summary>
	/// <param name="organizationId">The organization ID</param>
	/// <param name="receiverProfile">The receiver profile to create</param>
	/// <param name="cancellationToken">The cancellation token</param>
	[Post("/organizations/{organizationId}/api/push/receivers/profiles")]
	Task<PushReceiverProfile> CreateOrganizationApiPushReceiversProfileAsync(
		string organizationId,
		[Body] PushReceiverProfile receiverProfile,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Delete a Push API receiver profile
	/// DELETE /organizations/{organizationId}/api/push/receivers/profiles/{receiverProfileIname}
	/// </summary>
	/// <param name="organizationId">The organization ID</param>
	/// <param name="receiverProfileIname">The receiver profile immutable name</param>
	/// <param name="cancellationToken">The cancellation token</param>
	[Delete("/organizations/{organizationId}/api/push/receivers/profiles/{receiverProfileIname}")]
	Task DeleteOrganizationApiPushReceiversProfileAsync(
		string organizationId,
		string receiverProfileIname,
		CancellationToken cancellationToken = default);
}
