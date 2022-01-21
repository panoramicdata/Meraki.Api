namespace Meraki.Api.Interfaces.General.Organizations;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IOrganizationsUplinks
{
	/// <summary>
	/// List the uplink status of every Meraki MX, MG and Z series devices in the organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	[ApiOperationId("getOrganizationUplinksStatuses")]
	[Get("/organizations/{organizationId}/uplinks/statuses")]
	Task<List<UplinkStatus>> GetOrganizationUplinksStatusesAsync(
		[AliasAs("organizationId")] string organizationId,
		[AliasAs("perPage")] int perPage = 1000,
		[AliasAs("startingAfter")] string? startingAfter = null,
		[AliasAs("endingBefore")] string? endingBefore = null,
		[AliasAs("networkIds")] List<int>? networkIds = null,
		[AliasAs("serials")] List<int>? serials = null,
		[AliasAs("iccids")] List<int>? iccids = null,
		CancellationToken cancellationToken = default);
}
