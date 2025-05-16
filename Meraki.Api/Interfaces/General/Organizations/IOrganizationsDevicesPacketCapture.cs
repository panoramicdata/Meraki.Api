namespace Meraki.Api.Interfaces.General.Organizations;
public interface IOrganizationsDevicesPacketCapture
{
	/// <summary>
	/// List Packet Captures
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationDevicesPacketCaptureCaptures")]
	[Get("/organizations/{organizationId}/devices/packetCapture/captures")]
	Task<OrganizationDevicesPacketCaptureCapturesResponse> GetOrganizationDevicesPacketCaptureCapturesAsync(
		string organizationId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Perform a packet capture on a device and store in Meraki Cloud. Only a single switch may be chosen per request, while multiple access points are allowed at once.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="request"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("createOrganizationDevicesPacketCaptureCapture")]
	[Get("/organizations/{organizationId}/devices/packetCapture/captures")]
	Task<OrganizationDevicesPacketCaptureFile> CreateOrganizationDevicesPacketCaptureCaptureAsync(
		string organizationId,
		[Body] OrganizationDevicesPacketCaptureCapturesCreateRequest request,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Delete a single packet capture from cloud using captureId
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="captureId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("deleteOrganizationDevicesPacketCaptureCapture")]
	[Delete("/organizations/{organizationId}/devices/packetCapture/captures/{captureId}")]
	Task DeleteOrganizationDevicesPacketCaptureCaptureAsync(
		string organizationId,
		string captureId,
		CancellationToken cancellationToken = default);
}
