namespace Meraki.Api.Interfaces.General.Organizations;

/// <summary>
/// Floor Plans Auto Locate Interface
/// </summary>
public interface IOrganizationsFloorPlansAutoLocate
{
	/// <summary>
	///	List auto locate details for each device in your organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	[ApiOperationId("getOrganizationFloorPlansAutoLocateDevices")]
	[Get("/organizations/{organizationId}/floorPlans/autoLocate/devices")]
	Task<FloorPlansAutoLocateDevices> GetOrganizationFloorPlansAutoLocateDevicesAsync(
		string organizationId,
		CancellationToken cancellationToken = default);

	/// <summary>
	///	Schedule auto locate jobs for one or more floor plans in a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="floorPlansAutoLocateJobsRequest">The list of auto locate jobs to be scheduled. Up to 100 jobs can be provided in a request.</param>
	[ApiOperationId("batchNetworkFloorPlansAutoLocateJobs")]
	[Post("/networks/{networkId}/floorPlans/autoLocate/jobs/batch")]
	Task<FloorPlansAutoLocateJobsResponse> BatchNetworkFloorPlansAutoLocateJobsAsync(
		string networkId,
		[Body] FloorPlansAutoLocateJobsRequest floorPlansAutoLocateJobsRequest,
		CancellationToken cancellationToken = default);

	/// <summary>
	///	Cancel Network Floor Plans Auto Locate Job
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="jobId">Job ID</param>
	[ApiOperationId("cancelNetworkFloorPlansAutoLocateJob")]
	[Post("/networks/{networkId}/floorPlans/autoLocate/jobs/{jobId}/cancel")]
	Task CancelNetworkFloorPlansAutoLocateJobAsync(
		string networkId,
		string jobId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Update the status of a finished auto locate job to be published, and update device locations
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="jobId">Job ID</param>
	/// <param name="floorPlansPublishAutoLocateJobRequest">The list of auto locate jobs to be scheduled. Up to 100 jobs can be provided in a request.</param>
	[ApiOperationId("publishNetworkFloorPlansAutoLocateJob")]
	[Post("/networks/{networkId}/floorPlans/autoLocate/jobs/{jobId}/publish")]
	Task<FloorPlansPublishAutoLocateJobResponse> PublishNetworkFloorPlansAutoLocateJobAsync(
		string networkId,
		string jobId,
		[Body] FloorPlansPublishAutoLocateJobRequest floorPlansPublishAutoLocateJobRequest,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Trigger auto locate recalculation for a job, and optionally set anchors
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="jobId">Job ID</param>
	/// <param name="floorPlansRecalculateAutoLocateJobRequest">The list of auto locate jobs to be scheduled. Up to 100 jobs can be provided in a request.</param>
	[ApiOperationId("recalculateNetworkFloorPlansAutoLocateJob")]
	[Post("/networks/{networkId}/floorPlans/autoLocate/jobs/{jobId}/recalculate")]
	Task<FloorPlansRecalculateAutoLocateJobResponse> RecalculateNetworkFloorPlansAutoLocateJobAsync(
		string networkId,
		string jobId,
		[Body] FloorPlansRecalculateAutoLocateJobRequest floorPlansRecalculateAutoLocateJobRequest,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// List the status of auto locate for each floorplan in your organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	[ApiOperationId("getOrganizationFloorPlansAutoLocateStatuses")]
	[Post("/organizations/{organizationId}/floorPlans/autoLocate/statuses")]
	Task<FloorPlansAutoLocateStatuses> GetOrganizationFloorPlansAutoLocateStatusesAsync(
		string organizationId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// List the status of auto locate for each floorplan in your organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	[ApiOperationId("getOrganizationFloorPlansAutoLocateStatuses")]
	[Post("/organizations/{organizationId}/floorPlans/autoLocate/statuses")]
	Task<FloorPlansAutoLocateStatuses> GetOrganizationFloorPlansAutoLocateStatusesAsync(
		string organizationId,
		CancellationToken cancellationToken = default);
}
