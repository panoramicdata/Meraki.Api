using Meraki.Api.Data;
using Refit;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Networks interface
	/// </summary>
	public interface INetworks
	{
		/// <summary>
		/// Return a network
		/// </summary>
		/// <param name="networkId">The network Id</param>
		[Get("/networks/{networkId}")]
		Task<Network> GetAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Return a network's SSIDs
		/// </summary>
		/// <param name="networkId">The network Id</param>
		[Get("/networks/{networkId}/ssids")]
		Task<List<NetworkSsid>> GetAllSsidsAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Return a network's device
		/// </summary>
		/// <param name="networkId">The network Id</param>
		/// <param name="serial">The device's serial number</param>
		[Get("/networks/{networkId}/devices/{serial}")]
		Task<Device> GetDeviceAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("serial")] string serial,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Blinks the LEDs on a device
		/// </summary>
		/// <param name="networkId">The network Id</param>
		/// <param name="serial">The device's serial number</param>
		[Post("/networks/{networkId}/devices/{serial}/blinkLeds")]
		Task BlinkDeviceLedsAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("serial")] string serial,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Reboots a device
		/// </summary>
		/// <param name="networkId">The network Id</param>
		/// <param name="serial">The device's serial number</param>
		[Post("/networks/{networkId}/devices/{serial}/reboot")]
		Task RebootDeviceAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("serial")] string serial,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Claims a device
		/// </summary>
		/// <param name="networkId">The network Id</param>
		/// <param name="serial">The device's serial number</param>
		[Post("/networks/{networkId}/devices/claim")]
		Task ClaimDeviceAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("serial")] string serial,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Return a network's devices
		/// </summary>
		/// <param name="networkId">The network Id</param>
		[Get("/networks/{networkId}/devices")]
		Task<Device> GetDevicesAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default);
	}
}
