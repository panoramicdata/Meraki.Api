namespace Meraki.Api.Interfaces.General.Devices;
public interface IDevicesWireless
{
	/// <summary>
	/// Fetch the health scores for a given AP on this network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getDeviceWirelessHealthScores")]
	[Get("/devices/{serial}/wireless/healthScores")]
	Task<WirelessHealthScores> GetDeviceWirelessHealthScoresAsync(
		string serial,
		CancellationToken cancellationToken = default);
}
