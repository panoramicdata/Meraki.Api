using Meraki.Api.Data;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	public interface IVpn
	{
		/// <summary>
		/// getOrganizationApplianceVpnStats
		/// </summary>
		/// <remarks>
		/// Show VPN history stat for networks in an organization
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The Organization id</param>
		/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 300. Default is 300.</param>
		/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
		/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
		/// <param name="networkIds">A list of Meraki network IDs to filter results to contain only specified networks. E.g.: networkIds[]=N_12345678&networkIds[]=L_3456</param>
		/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 31 days from today.</param>
		/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 31 days after t0.</param>
		/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 31 days. The default is 1 day.</param>
		/// <returns>Task of Object</returns>
		[Get("/organizations/{organizationId}/appliance/vpn/stats")]
		Task<List<VpnStats>> GetOrganizationApplianceVpnStats(
			[AliasAs("organizationId")] string organizationId,
			[AliasAs("perPage")] int? perPage = null,
			[AliasAs("startingAfter")] string? startingAfter = null,
			[AliasAs("endingBefore")] string? endingBefore = null,
			[AliasAs("networkIds")] List<string>? networkIds = null,
			[AliasAs("t0")] string? t0 = null,
			[AliasAs("t1")] string? t1 = null,
			[AliasAs("timespan")] double? timespan = null
			);

		/// <summary>
		/// getOrganizationApplianceVpnStatuses
		/// </summary>
		/// <remarks>
		/// Show VPN status for networks in an organization
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The Organization id</param>
		/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 300. Default is 300.</param>
		/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
		/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
		/// <param name="networkIds">A list of Meraki network IDs to filter results to contain only specified networks. E.g.: networkIds[]=N_12345678&networkIds[]=L_3456</param>
		/// <returns>Task of Object</returns>
		[Get("/organizations/{organizationId}/appliance/vpn/statuses")]
		Task<List<VpnStatus>> GetOrganizationApplianceVpnStatuses(
			[AliasAs("organizationId")] string organizationId,
			[AliasAs("perPage")] int? perPage = null,
			[AliasAs("startingAfter")] string? startingAfter = null,
			[AliasAs("endingBefore")] string? endingBefore = null,
			[AliasAs("networkIds")] List<string>? networkIds = null
			);

		/// <summary>
		/// getNetworkApplianceVpnBgp
		/// </summary>
		/// <remarks>
		/// Return a Hub BGP Configuration
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/appliance/vpn/bgp")]
		Task<VpnBgp> GetNetworkApplianceVpnBgp(
			[AliasAs("networkId")] string networkId
			);

		/// <summary>
		/// updateNetworkApplianceVpnBgp
		/// </summary>
		/// <remarks>
		/// Return a Hub BGP Configuration
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="updateNetworkApplianceVpnBgp"></param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/appliance/vpn/bgp")]
		Task<VpnBgp> UpdateNetworkApplianceVpnBgp(
			[AliasAs("networkId")] string networkId,
			[Body]VpnBgp updateNetworkApplianceVpnBgp
			);
	}
}
