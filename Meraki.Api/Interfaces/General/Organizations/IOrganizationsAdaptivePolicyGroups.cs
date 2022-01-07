namespace Meraki.Api.Interfaces.General.Organizations;

public interface IOrganizationsAdaptivePolicyGroups
{
	/// <summary>
	/// List adaptive policy groups in a organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	///[Get("/organizations/{organizationId}/adaptivePolicy/groups")]
	///Task<List<AdaptivePolicyGroup>> GetOrganizationAdaptivePolicyGroupsAsync(
		///[AliasAs("organizationId")] string organizationId,
		///CancellationToken cancellationToken = default);
}
