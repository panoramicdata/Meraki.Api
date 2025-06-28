namespace Meraki.Api.Data;

/// <summary>
/// onboarding information
/// </summary>
[DataContract]
public class WirelessDeviceHealthScoreOnboarding
{
	/// <summary>
	/// device onboarding score
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "latest")]
	public int Latest { get; set; }
}