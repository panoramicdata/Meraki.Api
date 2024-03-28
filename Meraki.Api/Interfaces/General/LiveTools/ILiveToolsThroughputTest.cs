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
	Task<LiveToolsThroughputTestCreateResponse> CreateDeviceLiveToolsThroughputTestAsync(
		string serial,
		[Body] LiveToolsThroughputTestCreateRequest createDeviceLiveToolsThroughputTest,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Return a throughput test job
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="throughputTestId">Throughput test ID</param>
	[ApiOperationId("getDeviceLiveToolsThroughputTest")]
	[Get("/devices/{serial}/liveTools/throughputTest/{throughputTestId}")]
	Task<LiveToolsThroughputTest> GetDeviceLiveToolsThroughputTestAsync(
		string serial,
		string throughputTestId,
		CancellationToken cancellationToken = default);
}
