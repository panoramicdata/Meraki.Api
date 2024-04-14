namespace Meraki.Api.Interfaces.General.LiveTools;

public interface ILiveToolsCableTest
{
	/// <summary>
	/// Enqueue a job to perform a cable test for the device on the specified ports.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="createDeviceLiveToolsCableTest">Body</param>
	[ApiOperationId("createDeviceLiveToolsCableTest")]
	[Post("/devices/{serial}/liveTools/cableTest")]
	Task<LiveToolsCableTest> CreateDeviceLiveToolsCableTestAsync(
		string serial,
		[Body] LiveToolsCableTestCreate createDeviceLiveToolsCableTest,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Return a cable test live tool job.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="id">The cable test id</param>
	[ApiOperationId("getDeviceLiveToolsCableTest")]
	[Get("/devices/{serial}/liveTools/cableTest/{id}")]
	Task<LiveToolsCableTestResult> GetDeviceLiveToolsCableTestAsync(
		string serial,
		string id,
		CancellationToken cancellationToken = default);
}
