namespace Meraki.Api.Interfaces.Products.Sm;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface ISmDevicesFields
{
	/// <summary>
	/// Modify the fields of a device
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="updateNetworkSmDeviceFields">Body for modifying a device</param>
	[Put("/networks/{networkId}/sm/devices/fields")]
	Task<List<SmDevice>> UpdateNetworkSmDevicesFieldsAsync(
		[AliasAs("networkId")] string networkId,
		[Body] SmDeviceFieldsUpdateRequest updateNetworkSmDeviceFields,
		CancellationToken cancellationToken = default
		);
}
