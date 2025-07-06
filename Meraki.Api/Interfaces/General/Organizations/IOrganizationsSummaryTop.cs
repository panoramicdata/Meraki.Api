namespace Meraki.Api.Interfaces.General.Organizations;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IOrganizationsSummaryTop
{
	/// <summary>
	/// Return the top 10 appliances sorted by utilization over given time range.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="t0">The beginning of the timespan for the data.</param>
	/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 31 days after t0.</param>
	/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 31 days. The default is 1 day.</param>
	/// <param name="networkTag">Match result to an exact network tag</param>
	/// <param name="deviceTag">Match result to an exact device tag</param>
	/// <param name="networkId">Match result to an exact network id</param>
	/// <param name="quantity">Set number of desired results to return. Default is 10.</param>
	/// <param name="ssidName">Filter results by ssid name</param>
	/// <param name="usageUplink">Filter results by usage uplink</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getOrganizationSummaryTopAppliancesByUtilization")]
	[Get("/organizations/{organizationId}/summary/top/appliances/byUtilization")]
	Task<List<ApplianceUtilizationSummary>> GetOrganizationSummaryTopAppliancesByUtilizationAsync(
		string organizationId,
		string? t0 = null,
		string? t1 = null,
		double? timespan = null,
		string? networkTag = null,
		string? deviceTag = null,
		string? networkId = null,
		int? quantity = null,
		string? ssidName = null,
		string? usageUplink = null,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Return the top applications sorted by data usage over given time range. Default unit is megabytes.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationSummaryTopApplicationsByUsage")]
	[Get("/organizations/{organizationId}/summary/top/applications/byUsage")]
	Task<List<ApplicationUsageSummary>> GetOrganizationSummaryTopApplicationsByUsageAsync(
		string organizationId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Return the top application categories sorted by data usage over given time range. Default unit is megabytes.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationSummaryTopApplicationsCategoriesByUsage")]
	[Get("/organizations/{organizationId}/summary/top/applications/categories/byUsage")]
	Task<List<ApplicationCategoryUsageSummary>> GetOrganizationSummaryTopApplicationsCategoriesByUsageAsync(
		string organizationId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Return metrics for organization's top 10 clients by data usage (in mb) over given time range.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="t0">The beginning of the timespan for the data.</param>
	/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 31 days after t0.</param>
	/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 31 days. The default is 1 day.</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getOrganizationSummaryTopClientsByUsage")]
	[Get("/organizations/{organizationId}/summary/top/clients/byUsage")]
	Task<List<ClientUsageSummary>> GetOrganizationSummaryTopClientsByUsageAsync(
		string organizationId,
		string? t0 = null,
		string? t1 = null,
		double? timespan = null,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Return metrics for organization's top clients by data usage (in mb) over given time range, grouped by manufacturer.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="t0">The beginning of the timespan for the data.</param>
	/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 31 days after t0.</param>
	/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 31 days. The default is 1 day.</param>
	/// <param name="networkTag">Match result to an exact network tag</param>
	/// <param name="deviceTag">Match result to an exact device tag</param>
	/// <param name="networkId">Match result to an exact network id</param>
	/// <param name="quantity">Set number of desired results to return. Default is 10.</param>
	/// <param name="ssidName">Filter results by ssid name</param>
	/// <param name="usageUplink">Filter results by usage uplink</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getOrganizationSummaryTopClientsManufacturersByUsage")]
	[Get("/organizations/{organizationId}/summary/top/clients/manufacturers/byUsage")]
	Task<List<ClientManufacturersSummary>> GetOrganizationSummaryTopClientsManufacturersByUsageAsync(
		string organizationId,
		string? t0 = null,
		string? t1 = null,
		double? timespan = null,
		string? networkTag = null,
		string? deviceTag = null,
		string? networkId = null,
		int? quantity = null,
		string? ssidName = null,
		string? usageUplink = null,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Return metrics for organization's top 10 devices sorted by data usage over given time range. Default unit is megabytes.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="t0">The beginning of the timespan for the data.</param>
	/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 31 days after t0.</param>
	/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 31 days. The default is 1 day.</param>
	/// <param name="networkTag">Match result to an exact network tag</param>
	/// <param name="deviceTag">Match result to an exact device tag</param>
	/// <param name="networkId">Match result to an exact network id</param>
	/// <param name="quantity">Set number of desired results to return. Default is 10.</param>
	/// <param name="ssidName">Filter results by ssid name</param>
	/// <param name="usageUplink">Filter results by usage uplink</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getOrganizationSummaryTopDevicesByUsage")]
	[Get("/organizations/{organizationId}/summary/top/devices/byUsage")]
	Task<List<DeviceUsageSummary>> GetOrganizationSummaryTopDevicesByUsageAsync(
		string organizationId,
		string? t0 = null,
		string? t1 = null,
		double? timespan = null,
		string? networkTag = null,
		string? deviceTag = null,
		string? networkId = null,
		int? quantity = null,
		string? ssidName = null,
		string? usageUplink = null,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Return metrics for organization's top 10 device models sorted by data usage over given time range. Default unit is megabytes.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="t0">The beginning of the timespan for the data.</param>
	/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 31 days after t0.</param>
	/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 31 days. The default is 1 day.</param>
	/// <param name="networkTag">Match result to an exact network tag</param>
	/// <param name="deviceTag">Match result to an exact device tag</param>
	/// <param name="networkId">Match result to an exact network id</param>
	/// <param name="quantity">Set number of desired results to return. Default is 10.</param>
	/// <param name="ssidName">Filter results by ssid name</param>
	/// <param name="usageUplink">Filter results by usage uplink</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getOrganizationSummaryTopDevicesModelsByUsage")]
	[Get("/organizations/{organizationId}/summary/top/devices/models/byUsage")]
	Task<List<DeviceModelUsageSummary>> GetOrganizationSummaryTopDevicesModelsByUsageAsync(
		string organizationId,
		string? t0 = null,
		string? t1 = null,
		double? timespan = null,
		string? networkTag = null,
		string? deviceTag = null,
		string? networkId = null,
		int? quantity = null,
		string? ssidName = null,
		string? usageUplink = null,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// List the client and status overview information for the networks in an organization. Usage is measured in kilobytes and from the last seven days.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationSummaryTopNetworksByStatus")]
	[Get("/organizations/{organizationId}/summary/top/networks/byStatus")]
	Task<List<NetworkStatusSummary>> GetOrganizationSummaryTopNetworksByStatusAsync(
		string organizationId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Return metrics for organization's top 10 ssids by data usage over given time range. Default unit is megabytes.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="t0">The beginning of the timespan for the data.</param>
	/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 31 days after t0.</param>
	/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 31 days. The default is 1 day.</param>
	/// <param name="networkTag">Match result to an exact network tag</param>
	/// <param name="deviceTag">Match result to an exact device tag</param>
	/// <param name="networkId">Match result to an exact network id</param>
	/// <param name="quantity">Set number of desired results to return. Default is 10.</param>
	/// <param name="ssidName">Filter results by ssid name</param>
	/// <param name="usageUplink">Filter results by usage uplink</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getOrganizationSummaryTopSsidsByUsage")]
	[Get("/organizations/{organizationId}/summary/top/ssids/byUsage")]
	Task<List<SsidUsageSummary>> GetOrganizationSummaryTopSsidsByUsageAsync(
		string organizationId,
		string? t0 = null,
		string? t1 = null,
		double? timespan = null,
		string? networkTag = null,
		string? deviceTag = null,
		string? networkId = null,
		int? quantity = null,
		string? ssidName = null,
		string? usageUplink = null,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Return metrics for organization's top 10 switches by energy usage over given time range. Default unit is joules.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="t0">The beginning of the timespan for the data.</param>
	/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 31 days after t0.</param>
	/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 31 days. The default is 1 day.</param>
	/// <param name="networkTag">Match result to an exact network tag</param>
	/// <param name="deviceTag">Match result to an exact device tag</param>
	/// <param name="networkId">Match result to an exact network id</param>
	/// <param name="quantity">Set number of desired results to return. Default is 10.</param>
	/// <param name="ssidName">Filter results by ssid name</param>
	/// <param name="usageUplink">Filter results by usage uplink</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getOrganizationSummaryTopSwitchesByEnergyUsage")]
	[Get("/organizations/{organizationId}/summary/top/switches/byEnergyUsage")]
	Task<List<EnergyUsageSummary>> GetOrganizationSummaryTopSwitchesByEnergyUsageAsync(
		string organizationId,
		string? t0 = null,
		string? t1 = null,
		double? timespan = null,
		string? networkTag = null,
		string? deviceTag = null,
		string? networkId = null,
		int? quantity = null,
		string? ssidName = null,
		string? usageUplink = null,
		CancellationToken cancellationToken = default);
}
