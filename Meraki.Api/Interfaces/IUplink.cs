using Meraki.Api.Data;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	public interface IUplink
	{
		/// <summary>
		/// getNetworkUplinkSettings
		/// </summary>
		/// <remarks>
		/// Returns the uplink settings for your MX network.
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/uplinkSettings")]
		Task<object> GetNetworkUplinkSettings(
			[AliasAs("networkId")] string networkId
			);

		/// <summary>
		/// updateNetworkUplinkSettings
		/// </summary>
		/// <remarks>
		/// Updates the uplink settings for your MX network.
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="updateNetworkUplinkSettings"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/uplinkSettings")]
		Task<object> UpdateNetworkUplinkSettings(
			[AliasAs("networkId")] string networkId,
			[Body] UplinkSettingsUpdateRequest updateNetworkUplinkSettings
			);

		/// <summary>
		/// getOrganizationApplianceUplinkStatuses
		/// </summary>
		/// <remarks>
		/// List the uplink status of every Meraki MX and Z series appliances in the organization
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The Organization id</param>
		/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 1000. Default is 1000.</param>
		/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
		/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
		/// <param name="networkIds">A list of network IDs. The returned devices will be filtered to only include these networks.</param>
		/// <param name="serials">A list of serial numbers. The returned devices will be filtered to only include these serials.</param>
		/// <param name="iccids">A list of ICCIDs. The returned devices will be filtered to only include these ICCIDs.</param>
		/// <returns>Task of Object</returns>
		[Get("/organizations/{organizationId}/appliance/uplink/statuses")]
		Task<List<UplinkStatus>> GetOrganizationApplianceUplinkStatuses(
			[AliasAs("organizationId")] string organizationId,
			[AliasAs("perPage")] int? perPage = null,
			[AliasAs("startingAfter")] string? startingAfter = null,
			[AliasAs("endingBefore")] string? endingBefore = null,
			[AliasAs("networkIds")] List<string>? networkIds = null,
			[AliasAs("serials")] List<string>? serials = null,
			[AliasAs("iccids")] List<string>? iccids = null
			);

		/// <summary>
		/// getOrganizationUplinksStatuses
		/// </summary>
		/// <remarks>
		/// List the uplink status of every Meraki MX, MG and Z series devices in the organization
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The Organization id</param>
		/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 1000. Default is 1000.</param>
		/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
		/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
		/// <param name="networkIds">A list of network IDs. The returned devices will be filtered to only include these networks.</param>
		/// <param name="serials">A list of serial numbers. The returned devices will be filtered to only include these serials.</param>
		/// <param name="iccids">A list of ICCIDs. The returned devices will be filtered to only include these ICCIDs.</param>
		/// <returns>Task of Object</returns>
		[Get("/organizations/{organizationId}/uplinks/statuses")]
		Task<List<UplinkStatus>> GetOrganizationUplinksStatuses(
			[AliasAs("organizationId")] string organizationId,
			[AliasAs("perPage")] int? perPage = null,
			[AliasAs("startingAfter")] string? startingAfter = null,
			[AliasAs("endingBefore")] string? endingBefore = null,
			[AliasAs("networkIds")] List<string>? networkIds = null,
			[AliasAs("serials")] List<string>? serials = null,
			[AliasAs("iccids")] List<string>? iccids = null
			);

		/// <summary>
		/// getOrganizationCellularGatewayUplinkStatuses
		/// </summary>
		/// <remarks>
		/// List the uplink status of every Meraki MG cellular gateway in the organization
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The Organization id</param>
		/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 1000. Default is 1000.</param>
		/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
		/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
		/// <param name="networkIds">A list of network IDs. The returned devices will be filtered to only include these networks.</param>
		/// <param name="serials">A list of serial numbers. The returned devices will be filtered to only include these serials.</param>
		/// <param name="iccids">A list of ICCIDs. The returned devices will be filtered to only include these ICCIDs.</param>
		/// <returns>Task of Object</returns>
		[Get("/organizations/{organizationId}/cellularGateway/uplink/statuses")]
		Task<List<UplinkStatus>> GetOrganizationCellularGatewayUplinkStatuses(
			[AliasAs("organizationId")] string organizationId,
			[AliasAs("perPage")] int? perPage = null,
			[AliasAs("startingAfter")] string? startingAfter = null,
			[AliasAs("endingBefore")] string? endingBefore = null,
			[AliasAs("networkIds")] List<string>? networkIds = null,
			[AliasAs("serials")] List<string>? serials = null,
			[AliasAs("iccids")] List<string>? iccids = null
			);
	}
}
