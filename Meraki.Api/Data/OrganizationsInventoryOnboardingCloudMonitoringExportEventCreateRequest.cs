namespace Meraki.Api.Data;

/// <summary>
/// Organizations Inventory Onboarding Cloud Monitoring Export Event Create Request
/// </summary>
[DataContract]
public class OrganizationsInventoryOnboardingCloudMonitoringExportEventCreateRequest
{
	/// <summary>
	/// A JavaScript UTC datetime stamp for when the even occurred
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "timestamp")]
	public int Timestamp { get; set; }

	/// <summary>
	/// The type of log event this is recording, e.g. download or opening a banner
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "logEvent")]
	public string LogEvent { get; set; } = string.Empty;

	/// <summary>
	/// Used to describe if this event was the result of a redirect. E.g. a query param if an info banner is being used
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "request")]
	public string? Request { get; set; }

	/// <summary>
	/// The name of the onboarding distro being downloaded
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "targetOs")]
	public string? TargetOs { get; set; }
}
