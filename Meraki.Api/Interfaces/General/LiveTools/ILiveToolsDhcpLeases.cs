namespace Meraki.Api.Interfaces.General.LiveTools;
public interface ILiveToolsDhcpLeases
{
	/// <summary>
	/// Return a DHCP leases live tool job.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial"></param>
	/// <param name="dhcpLeasesId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getDeviceLiveToolsDhcpLease")]
	[Get("/devices/{serial}/liveTools/dhcpLeases/{dhcpLeasesId}")]
	Task<DeviceLiveToolsDhcpLeaseGetResponse> GetDeviceLiveToolsDhcpLeaseAsync(string serial, string dhcpLeasesId, CancellationToken cancellationToken = default);

	/// <summary>
	/// Enqueue a job to perform a DHCP leases request for the device. This endpoint currently supports all devices. This endpoint has a sustained rate limit of one request every five seconds per device, with an allowed burst of five requests.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial"></param>
	/// <param name="request"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("createDeviceLiveToolsDhcpLease")]
	[Post("/devices/{serial}/liveTools/dhcpLeases")]
	Task<DeviceLiveToolsDhcpLeaseCreateResponse> CreateDeviceLiveToolsDhcpLeaseAsync(
		string serial,
		[Body] DeviceLiveToolsDhcpLeaseCreateRequest request,
		CancellationToken cancellationToken = default);
}
