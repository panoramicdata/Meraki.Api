namespace Meraki.Api.Interfaces.Products.Appliance;

public interface IApplianceVpnStatuses
{
	/// <summary>
	/// Show VPN status for networks in an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 300. Default is 300.</param>
	/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	/// <param name="networkIds">A list of Meraki network IDs to filter results to contain only specified networks. E.g.: networkIds[]=N_12345678&amp;networkIds[]=L_3456</param>
	/// <param name="cancellationToken"></param>
	[Get("/organizations/{organizationId}/appliance/vpn/statuses")]
	Task<List<VpnStatus>> GetOrganizationApplianceVpnStatusesAsync(
		string organizationId,
		int? perPage = 300,
		string? startingAfter = null,
		string? endingBefore = null,
		[AliasAs("networkIds[]")] List<string>? networkIds = null,
		CancellationToken cancellationToken = default
		);

	[Get("/organizations/{organizationId}/appliance/vpn/statuses")]
	internal Task<ApiResponse<List<VpnStatus>>> GetOrganizationApplianceVpnStatusesApiResponseAsync(
		string organizationId,
		string? startingAfter = null,
		string? endingBefore = null,
		[AliasAs("networkIds[]")] List<string>? networkIds = null,
		CancellationToken cancellationToken = default
		);
}
