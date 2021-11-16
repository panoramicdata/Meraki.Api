namespace Meraki.Api.Interfaces.Products.Switch;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface ISwitchWarmSpare
{
	/// <summary>
	/// Return warm spare configuration for a switch
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	[ApiOperationId("getDeviceSwitchWarmSpare")]
	[Get("/devices/{serial}/switch/warmSpare")]
	Task<SwitchWarmSpare> GetDeviceSwitchWarmSpareAsync(
		[AliasAs("serial")] string serial,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update warm spare configuration for a switch
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="updateDeviceSwitchWarmSpare"></param>
	[ApiOperationId("updateDeviceSwitchWarmSpare")]
	[Put("/devices/{serial}/switch/warmSpare")]
	Task<SwitchWarmSpare> UpdateDeviceSwitchWarmSpareAsync(
		[AliasAs("serial")] string serial,
		[Body] SwitchWarmSpareUpdateRequest updateDeviceSwitchWarmSpare,
		CancellationToken cancellationToken = default);
}
