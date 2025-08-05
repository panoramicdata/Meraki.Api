namespace Meraki.Api.Interfaces.General.Networks;
public interface INetworksSensorSchedules
{
	/// <summary>
	/// Returns a list of all sensor schedules.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getNetworkSensorSchedules")]
	[Get("/networks/{networkId}/sensor/schedules")]
	Task<List<NetworkSensorSchedule>> GetNetworkSensorSchedulesAsync(
		string networkId,
		CancellationToken cancellationToken = default);
}
