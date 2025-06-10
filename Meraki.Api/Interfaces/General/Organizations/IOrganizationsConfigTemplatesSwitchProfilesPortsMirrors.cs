namespace Meraki.Api.Interfaces.General.Organizations;
public interface IOrganizationsConfigTemplatesSwitchProfilesPortsMirrors
{
	/// <summary>
	/// List the port mirror configurations in an organization by switch profile
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationConfigTemplatesSwitchProfilesPortsMirrorsBySwitchProfile")]
	[Get("/organizations/{organizationId}/configTemplates/switch/profiles/ports/mirrors/bySwitchProfile")]
	Task<OrganizationConfigTemplatesSwitchProfilesPortsMirrorsBySwitchProfileResponse> GetOrganizationConfigTemplatesSwitchProfilesPortsMirrorsBySwitchProfileAsync(
		string organizationId,
		CancellationToken cancellationToken = default
	);
}
