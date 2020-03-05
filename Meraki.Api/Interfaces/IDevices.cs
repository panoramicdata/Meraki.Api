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
