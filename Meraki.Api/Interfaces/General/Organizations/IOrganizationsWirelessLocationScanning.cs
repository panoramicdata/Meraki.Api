namespace Meraki.Api.Interfaces.General.Organizations;

public interface IOrganizationsWirelessLocationScanning
{
	/// <summary>
	/// Return scanning API settings
	/// </summary>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationWirelessLocationScanningByNetwork")]
	[Get("/organizations/{organizationId}/wireless/location/scanning/byNetwork")]
	Task<WirelessLocationScanningByNetwork> GetOrganizationWirelessLocationScanningByNetworkAsync(
		string organizationId,
		CancellationToken cancellationToken = default
		);
}
