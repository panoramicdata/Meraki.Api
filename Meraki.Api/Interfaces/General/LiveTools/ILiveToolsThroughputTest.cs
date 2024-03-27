namespace Meraki.Api.Interfaces.General.LiveTools;

public interface ILiveToolsThroughputTest
{
	/// <summary>
	/// Enqueue a job to test a device throughput, the test will run for 10 secs to test throughput
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="createDeviceLiveToolsThroughputTest">Body</param>
	[ApiOperationId("createDeviceLiveToolsThroughputTest")]
	[Post("/devices/{serial}/liveTools/throughputTest")]
	Task<LiveToolsThroughputTest> CreateDeviceLiveToolsThroughputTestAsync(
		string serial,
		[Body] LiveToolsThroughputTestCreate createDeviceLiveToolsThroughputTest,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Return a ping job. Latency unit in response is in milliseconds. Size is in bytes.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	[ApiOperationId("getDeviceLiveToolsPingDevice")]
	[Get("/devices/{serial}/liveTools/pingDevice/{id}")]
	Task<LiveToolsPing> GetDeviceLiveToolsPingDeviceAsync(
		string serial,
		string id,
		CancellationToken cancellationToken = default);
}
