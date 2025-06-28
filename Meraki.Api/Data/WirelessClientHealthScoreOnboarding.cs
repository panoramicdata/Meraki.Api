namespace Meraki.Api.Data;

/// <summary>
/// Onboarding
/// </summary>
[DataContract]
public class WirelessClientHealthScoreOnboarding
{
	/// <summary>
	/// Latest
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "latest")]
	public int Latest { get; set; }
}