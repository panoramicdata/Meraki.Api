using Meraki.Api.Data;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Devices interface
	/// </summary>
	public interface IDevices
	{
		///<summary>
		/// Returns a device from a given network
		/// </summary>
		/// <param name="networkId">The network id</param>
		/// <param name="serial">The device serial number</param>
		[Get("/networks/devices/{serial}")]
		Task<Device> GetAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("serial")] string serial,
					CancellationToken cancellationToken = default);

		///<summary>
		/// Returns quality and retention settings for the given camera
		/// </summary>
		/// <param name="serial">The camera serial number</param>
		[Get("/devices/{serial}/camera/qualityAndRetentionSettings")]
		Task<CameraQualityAndRetentionSettings> GetCameraQualityAndRetentionSettingsAsync(
			[AliasAs("serial")] string serial,
					CancellationToken cancellationToken = default);

		///<summary>
		/// Update quality and retention settings for the given camera
		/// </summary>
		/// <param name="serial">The camera serial number</param>
		[Get("/devices/{serial}/camera/qualityAndRetentionSettings")]
		Task<CameraQualityAndRetentionSettings> SetCameraQualityAndRetentionSettingsAsync(
			[AliasAs("serial")] string serial,
			[Body] CameraQualityAndRetentionSettings cameraQualityAndRetentionSettings,
					CancellationToken cancellationToken = default);
	}
}
