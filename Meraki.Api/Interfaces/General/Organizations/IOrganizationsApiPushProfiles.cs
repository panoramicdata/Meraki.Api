namespace Meraki.Api.Interfaces.General.Organizations;

/// <summary>
/// Interface for Push API Profiles
/// </summary>
public interface IOrganizationsApiPushProfiles
{
	/// <summary>
	/// Create a Push API profile (subscribe to a topic)
	/// POST /organizations/{organizationId}/api/push/profiles
	/// </summary>
	/// <param name="organizationId">The organization ID</param>
	/// <param name="pushProfile">The push profile to create</param>
	/// <param name="cancellationToken">The cancellation token</param>
	[Post("/organizations/{organizationId}/api/push/profiles")]
	Task<PushProfile> CreateOrganizationApiPushProfileAsync(
		string organizationId,
		[Body] PushProfile pushProfile,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Update a Push API profile
	/// PUT /organizations/{organizationId}/api/push/profiles/{pushProfileIname}
	/// </summary>
	/// <param name="organizationId">The organization ID</param>
	/// <param name="pushProfileIname">The push profile immutable name</param>
	/// <param name="updateRequest">The update request</param>
	/// <param name="cancellationToken">The cancellation token</param>
	[Put("/organizations/{organizationId}/api/push/profiles/{pushProfileIname}")]
	Task<PushProfile> UpdateOrganizationApiPushProfileAsync(
		string organizationId,
		string pushProfileIname,
		[Body] PushProfileUpdateRequest updateRequest,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Delete a Push API profile
	/// DELETE /organizations/{organizationId}/api/push/profiles/{pushProfileIname}
	/// </summary>
	/// <param name="organizationId">The organization ID</param>
	/// <param name="pushProfileIname">The push profile immutable name</param>
	/// <param name="cancellationToken">The cancellation token</param>
	[Delete("/organizations/{organizationId}/api/push/profiles/{pushProfileIname}")]
	Task DeleteOrganizationApiPushProfileAsync(
		string organizationId,
		string pushProfileIname,
		CancellationToken cancellationToken = default);
}
