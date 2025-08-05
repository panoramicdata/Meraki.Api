namespace Meraki.Api.Interfaces.General.Organizations;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IOrganizationsClients
{
	/// <summary>
	/// Return the client details in an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="mac">The MAC address of the client. Required.</param>
	/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 5. Default is 5.</param>
	/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	/// <param name="cancellationToken"></param>
	[Get("/organizations/{organizationId}/clients/search")]
	Task<ClientSearchResult> GetOrganizationClientsSearchAsync(
		string organizationId,
		string mac,
		int perPage = 5,
		string? startingAfter = null,
		string? endingBefore = null,
		CancellationToken cancellationToken = default);
}
