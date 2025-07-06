namespace Meraki.Api.Interfaces.Products.Appliance;

public interface IApplianceUplinkStatuses
{
	/// <summary>
	/// List the uplink status of every Meraki MX and Z series appliances in the organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 1000. Default is 1000.</param>
	/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	/// <param name="networkIds">A list of network IDs. The returned devices will be filtered to only include these networks.</param>
	/// <param name="serials">A list of serial numbers. The returned devices will be filtered to only include these serials.</param>
	/// <param name="iccids">A list of ICCIDs. The returned devices will be filtered to only include these ICCIDs.</param>
	/// <param name="cancellationToken"></param>
	[Get("/organizations/{organizationId}/appliance/uplink/statuses")]
	Task<List<UplinkStatus>> GetOrganizationApplianceUplinkStatusesAsync(
		string organizationId,
		int? perPage = 1000,
		string? startingAfter = null,
		string? endingBefore = null,
		[AliasAs("networkIds[]")] List<string>? networkIds = null,
		[AliasAs("serials[]")] List<string>? serials = null,
		[AliasAs("iccids[]")] List<string>? iccids = null,
		CancellationToken cancellationToken = default
		);
}
