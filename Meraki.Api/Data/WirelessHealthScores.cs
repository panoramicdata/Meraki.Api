namespace Meraki.Api.Data;

/// <summary>
/// Wireless Health Scores
/// </summary>
[DataContract]
public class WirelessHealthScores
{
	/// <summary>
	/// device information
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "device")]
	public WirelessHealthScoresDevice Device { get; set; } = new();

	/// <summary>
	/// onboarding information
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "onboarding")]
	public WirelessHealthScoresOnboarding Onboarding { get; set; } = new();

	/// <summary>
	/// performance information
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "performance")]
	public WirelessHealthScoresPerformance Performance { get; set; } = new();
}
