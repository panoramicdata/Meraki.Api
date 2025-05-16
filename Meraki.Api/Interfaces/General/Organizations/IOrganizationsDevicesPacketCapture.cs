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
	[Post("/organizations/{organizationId}/devices/packetCapture/captures")]
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

	/// <summary>
	/// Perform a packet capture on multiple devices and store in Meraki Cloud.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="request"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("bulkOrganizationDevicesPacketCaptureCapturesCreate")]
	[Post("/organizations/{organizationId}/devices/packetCapture/captures/bulkCreate")]
	Task<OrganizationDevicesPacketCaptureCapturesBulkCreateResponse> BulkOrganizationDevicesPacketCaptureCapturesCreateAsync(
		string organizationId,
		[Body] List<OrganizationDevicesPacketCaptureCapturesBulkCreateRequest> request,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// BulkDelete packet captures from cloud
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="request"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("bulkOrganizationDevicesPacketCaptureCapturesDelete")]
	[Post("/organizations/{organizationId}/devices/packetCapture/captures/bulkDelete")]
	Task BulkOrganizationDevicesPacketCaptureCapturesDeleteAsync(
		string organizationId,
		[Body] OrganizationDevicesPacketCaptureCapturesBulkDeleteRequest request,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Get presigned download URL for given packet capture id
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="captureId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("generateOrganizationDevicesPacketCaptureCaptureDownloadUrl")]
	[Post("/organizations/{organizationId}/devices/packetCapture/captures/{captureId}/downloadUrl/generate")]
	Task<OrganizationDevicesPacketCaptureCaptureDownloadUrl> GenerateOrganizationDevicesPacketCaptureCaptureDownloadUrlAsync(
		string organizationId,
		string captureId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Stop a specific packet capture (not supported for Catalyst devices)
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="captureId"></param>
	/// <param name="request"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("stopOrganizationDevicesPacketCaptureCapture")]
	[Post("/organizations/{organizationId}/devices/packetCapture/captures/{captureId}/stop")]
	Task<OrganizationDevicesPacketCaptureFile> StopOrganizationDevicesPacketCaptureCaptureAsync(
		string organizationId,
		string captureId,
		[Body] OrganizationDevicesPacketCaptureCapturesStopRequest request,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// List the Packet Capture Schedules
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationDevicesPacketCaptureSchedules")]
	[Get("/organizations/{organizationId}/devices/packetCapture/schedules")]
	Task<OrganizationDevicesPacketCaptureSchedulesResponse> GetOrganizationDevicesPacketCaptureSchedulesAsync(
		string organizationId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Create a schedule for packet capture
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="request"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("createOrganizationDevicesPacketCaptureSchedule")]
	[Post("/organizations/{organizationId}/devices/packetCapture/schedules")]
	Task<OrganizationDevicesPacketCaptureSchedule> CreateOrganizationDevicesPacketCaptureScheduleAsync(
		string organizationId,
		[Body] OrganizationDevicesPacketCaptureScheduleCreateRequest request,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Update a schedule for packet capture
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="scheduleId"></param>
	/// <param name="request"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("updateOrganizationDevicesPacketCaptureSchedule")]
	[Put("/organizations/{organizationId}/devices/packetCapture/schedules/{scheduleId}")]
	Task<OrganizationDevicesPacketCaptureSchedule> UpdateOrganizationDevicesPacketCaptureScheduleAsync(
		string organizationId,
		string scheduleId,
		[Body] OrganizationDevicesPacketCaptureScheduleUpdateRequest request,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Delete schedule from cloud
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="scheduleId"></param>
	/// <param name="request"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("deleteOrganizationDevicesPacketCaptureSchedule")]
	[Delete("/organizations/{organizationId}/devices/packetCapture/schedules/{scheduleId}")]
	Task DeleteOrganizationDevicesPacketCaptureScheduleAsync(
		string organizationId,
		string scheduleId,
		[Body] OrganizationDevicesPacketCaptureScheduleDeleteRequest request,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Delete packet capture schedules
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="request"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("bulkOrganizationDevicesPacketCaptureSchedulesDelete")]
	[Post("/organizations/{organizationId}/devices/packetCapture/schedules/bulkDelete")]
	Task BulkOrganizationDevicesPacketCaptureSchedulesDeleteAsync(
		string organizationId,
		[Body] OrganizationDevicesPacketCaptureSchedulesBulkDeleteRequest request,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Bulk update priorities of pcap schedules
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="request"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("reorderOrganizationDevicesPacketCaptureSchedules")]
	[Post("/organizations/{organizationId}/devices/packetCapture/schedules/reorder")]
	Task<OrganizationDevicesPacketCaptureSchedulesReorderResponse> ReorderOrganizationDevicesPacketCaptureSchedulesAsync(
		string organizationId,
		[Body] OrganizationDevicesPacketCaptureSchedulesReorderRequest request,
		CancellationToken cancellationToken = default);
}
