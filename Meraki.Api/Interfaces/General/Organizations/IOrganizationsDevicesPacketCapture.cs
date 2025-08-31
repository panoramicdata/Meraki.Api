namespace Meraki.Api.Interfaces.General.Organizations;
public interface IOrganizationsDevicesPacketCapture
{
	/// <summary>
	/// List Packet Captures
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">Organization ID</param>
	/// <param name="captureIds">Return the packet captures of the specified capture ids</param>
	/// <param name="networkIds">Return the packet captures of the specified network(s)</param>
	/// <param name="serials">Return the packet captures of the specified device(s)</param>
	/// <param name="process">Return the packet captures of the specified process</param>
	/// <param name="captureStatus">Return the packet captures of the specified capture status</param>
	/// <param name="name">Return the packet captures matching the specified name</param>
	/// <param name="clientMac">Return the packet captures matching the specified client macs</param>
	/// <param name="notes">Return the packet captures matching the specified notes</param>
	/// <param name="deviceName">Return the packet captures matching the specified device name</param>
	/// <param name="adminName">Return the packet captures matching the admin name</param>
	/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 100. Default is 10.</param>
	/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	/// <param name="sortOrder">Sorted order of entries. Order options are 'ascending' and 'descending'. Default is 'descending'. enum = ["ascending", "descending"]</param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationDevicesPacketCaptureCaptures")]
	[Get("/organizations/{organizationId}/devices/packetCapture/captures")]
	Task<OrganizationDevicesPacketCaptureCapturesResponse> GetOrganizationDevicesPacketCaptureCapturesAsync(
		string organizationId,
		[AliasAs("captureIds[]")] List<string>? captureIds = null,
		[AliasAs("networkIds[]")] List<string>? networkIds = null,
		[AliasAs("serials[]")] List<string>? serials = null,
		[AliasAs("process[]")] List<string>? process = null,
		[AliasAs("captureStatus[]")] List<string>? captureStatus = null,
		[AliasAs("name[]")] List<string>? name = null,
		[AliasAs("clientMac[]")] List<string>? clientMac = null,
		string? notes = null,
		string? deviceName = null,
		string? adminName = null,
		int? perPage = 10,
		string? startingAfter = null,
		string? endingBefore = null,
		string? sortOrder = null,
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

	/// <summary>
	/// Enqueues a task for a specific packet capture. This endpoint has a sustained rate limit of one request every 60 seconds.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="packetId"></param>
	/// <param name="request"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("tasksOrganizationDevicesPacketCapture")]
	[Post("/organizations/{organizationId}/devices/packetCaptures/{packetId}/tasks")]
	Task<OrganizationDevicesPacketCaptureTask> CreateOrganizationDevicesPacketCaptureTaskAsync(
		string organizationId,
		string packetId,
		[Body] OrganizationDevicesPacketCaptureTaskCreateRequest request,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Retrieves packet capture analysis result for a specific packet capture task.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="packetId"></param>
	/// <param name="id"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationDevicesPacketCaptureTask")]
	[Get("/organizations/{organizationId}/devices/packetCaptures/{packetId}/tasks/{id}")]
	Task<OrganizationDevicesPacketCaptureTaskDetailed> GetOrganizationDevicesPacketCaptureTaskAsync(
		string organizationId,
		string packetId,
		string id,
		CancellationToken cancellationToken = default);
}
