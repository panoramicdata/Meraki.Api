namespace Meraki.Api.Interfaces.General.Organizations;
public interface IWirelessZigbee
{
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	[ApiOperationId("getOrganizationWirelessZigbeeByNetwork")]
	[Get("/organizations/{organizationId}/wireless/zigbee/byNetwork")]
	Task<List<OrganizationZigbee>> GetOrganizationZigbeesByNetworkAsync(
		string organizationId,
		CancellationToken cancellationToken = default
	);
}
