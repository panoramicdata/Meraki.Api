namespace Meraki.Api.Data;

/// <summary>
/// Wireless Client Onboarding History
/// </summary>
[DataContract]
public class WirelessClientOnboardingHistory
{
	/// <summary>
	/// The end time of the query range
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "endTs")]
	public string EndTs { get; set; } = string.Empty;

	/// <summary>
	/// The start time of the query range
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "startTs")]
	public string StartTs { get; set; } = string.Empty;

	/// <summary>
	/// Client connection counts
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "clientCounts")]
	public WirelessClientOnboardingHistoryClientCounts ClientCounts { get; set; } = new();
}
