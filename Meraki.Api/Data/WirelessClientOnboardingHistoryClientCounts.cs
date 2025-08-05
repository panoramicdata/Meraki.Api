namespace Meraki.Api.Data;

/// <summary>
/// Client connection counts
/// </summary>
[DataContract]
public class WirelessClientOnboardingHistoryClientCounts
{
	/// <summary>
	/// Client connections broken down by step
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "connectionSteps")]
	public WirelessClientOnboardingHistoryClientCountsConnectionSteps ConnectionSteps { get; set; } = new();

	/// <summary>
	/// Client connections across all steps
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "summary")]
	public WirelessClientOnboardingHistoryClientCountsSummary Summary { get; set; } = new();
}
