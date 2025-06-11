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
}
