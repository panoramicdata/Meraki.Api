namespace Meraki.Api.Data;

/// <summary>
/// Wireless Device Health Score
/// </summary>
[DataContract]
public class WirelessDeviceHealthScore
{
	/// <summary>
	/// device information
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "device")]
	public WirelessDeviceHealthScoreDevice Device { get; set; } = new();

	/// <summary>
	/// onboarding information
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "onboarding")]
	public WirelessDeviceHealthScoreOnboarding Onboarding { get; set; } = new();

	/// <summary>
	/// performance information
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "performance")]
	public WirelessDeviceHealthScorePerformance Performance { get; set; } = new();
}
