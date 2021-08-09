using Refit;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IMvSense
	{
		/// <summary>
		/// getDeviceCameraAnalyticsLive
		/// </summary>
		/// <remarks>
		/// Returns live state from camera of analytics zones
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial"></param>
		/// <returns>Task of Object</returns>
		[Get("/devices/{serial}/camera/analytics/live")]
		Task<object> GetDeviceCameraAnalyticsLive(
			[AliasAs("serial")]string serial
			);

		/// <summary>
		/// getDeviceCameraAnalyticsOverview
		/// </summary>
		/// <remarks>
		/// Returns an overview of aggregate analytics data for a timespan
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial"></param>
		/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 365 days from today. (optional)</param>
		/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 7 days after t0. (optional)</param>
		/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 7 days. The default is 1 hour. (optional)</param>
		/// <param name="objectType">[optional] The object type for which analytics will be retrieved. The default object type is person. The available types are [person, vehicle]. (optional)</param>
		/// <returns>Task of Object</returns>
		[Get("/devices/{serial}/camera/analytics/overview")]
		Task<object> GetDeviceCameraAnalyticsOverview(
			[AliasAs("serial")]string serial,
			[AliasAs("t0")]string t0 = null!,
			[AliasAs("t1")]string t1 = null!,
			[AliasAs("timespan")]double? timespan = null,
			[AliasAs("objectType")]string objectType = null!
			);

		/// <summary>
		/// getDeviceCameraAnalyticsRecent
		/// </summary>
		/// <remarks>
		/// Returns most recent record for analytics zones
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial"></param>
		/// <param name="objectType">[optional] The object type for which analytics will be retrieved. The default object type is person. The available types are [person, vehicle]. (optional)</param>
		/// <returns>Task of Object</returns>
		[Get("/devices/{serial}/camera/analytics/recent")]
		Task<object> GetDeviceCameraAnalyticsRecent(
			[AliasAs("serial")]string serial,
			[AliasAs("objectType")]string objectType = null!
			);

		/// <summary>
		/// getDeviceCameraAnalyticsZoneHistory
		/// </summary>
		/// <remarks>
		/// Return historical records for analytic zones
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial"></param>
		/// <param name="zoneId"></param>
		/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 365 days from today. (optional)</param>
		/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 14 hours after t0. (optional)</param>
		/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 14 hours. The default is 1 hour. (optional)</param>
		/// <param name="resolution">The time resolution in seconds for returned data. The valid resolutions are: 60. The default is 60. (optional)</param>
		/// <param name="objectType">[optional] The object type for which analytics will be retrieved. The default object type is person. The available types are [person, vehicle]. (optional)</param>
		/// <returns>Task of Object</returns>
		[Get("/devices/{serial}/camera/analytics/zones/{zoneId}/history")]
		Task<object> GetDeviceCameraAnalyticsZoneHistory(
			[AliasAs("serial")]string serial,
			[AliasAs("zoneId")]string zoneId,
			[AliasAs("t0")]string t0 = null!,
			[AliasAs("t1")]string t1 = null!,
			[AliasAs("timespan")]double? timespan = null,
			[AliasAs("resolution")]int? resolution = null,
			[AliasAs("objectType")]string objectType = null!
			);

		/// <summary>
		/// getDeviceCameraAnalyticsZones
		/// </summary>
		/// <remarks>
		/// Returns all configured analytic zones for this camera
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial"></param>
		/// <returns>Task of Object</returns>
		[Get("/devices/{serial}/camera/analytics/zones")]
		Task<object> GetDeviceCameraAnalyticsZones(
			[AliasAs("serial")]string serial
			);
	}
}
