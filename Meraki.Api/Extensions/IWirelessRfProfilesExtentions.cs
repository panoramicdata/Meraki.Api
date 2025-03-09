namespace Meraki.Api.Extensions;

public static class IWirelessRfProfilesExtensions
{
	/// <summary>
	/// List all the non-basic RF profiles for this network.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call.</exception>
	/// <param name="organizationId">Organization ID.</param>
	/// <param name="networkIds">Optional parameter to filter devices by network.</param>
	/// <param name="productTypes">Optional parameter to filter devices by product type. Valid types are wireless, appliance, switch, systemsManager, camera, cellularGateway, and sensor.</param>
	/// <param name="name">Optional parameter to filter RF profiles by device name. All returned devices will have a name that contains the search term or is an exact match.</param>
	/// <param name="mac">Optional parameter to filter RF profiles by device MAC address. All returned devices will have a MAC address that contains the search term or is an exact match.</param>
	/// <param name="serial">Optional parameter to filter RF profiles by device serial number. All returned devices will have a serial number that contains the search term or is an exact match.</param>
	/// <param name="model">Optional parameter to filter RF profiles by device model. All returned devices will have a model that contains the search term or is an exact match.</param>
	/// <param name="macs">Optional parameter to filter RF profiles by one or more device MAC addresses. All returned devices will have a MAC address that is an exact match.</param>
	/// <param name="serials">Optional parameter to filter RF profiles by one or more device serial numbers. All returned devices will have a serial number that is an exact match.</param>
	/// <param name="models">Optional parameter to filter RF profiles by one or more device models. All returned devices will have a model that is an exact match.</param>
	/// <param name="cancellationToken">The cancellation token.</param>
	public static Task<List<RfProfilesByDevice>> GetOrganizationWirelessRfProfilesAssignmentsByDeviceAllAsync(
		this IWirelessRfProfiles wirelessRfProfilesAssignments,
		string organizationId,
		List<string>? networkIds,
		List<ProductType> productTypes,
		string? name,
		string? mac,
		string? serial,
		string? model,
		List<string>? macs,
		List<string>? serials,
		List<string>? models,
		CancellationToken cancellationToken = default)
		=> MerakiClient.GetAllAsync(
				(startingAfter, endingBefore, cancellationToken)
				=> wirelessRfProfilesAssignments.GetOrganizationWirelessRfProfilesAssignmentsByDeviceApiResponseAsync(
						organizationId,
						startingAfter,
						endingBefore,
						networkIds,
						productTypes,
						name,
						mac,
						serial,
						model,
						macs,
						serials,
						models,
						cancellationToken
					),
					cancellationToken
			);
}
