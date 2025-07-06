namespace Meraki.Api.Data;

/// <summary>
/// Wireless Client Health Score
/// </summary>
[DataContract]
public class WirelessClientHealthScore
{
	/// <summary>
	/// Mac address
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "mac")]
	public string Mac { get; set; } = string.Empty;

	/// <summary>
	/// Client ID
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "clientId")]
	public string ClientId { get; set; } = string.Empty;

	/// <summary>
	/// Performance
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "performance")]
	public WirelessClientHealthScorePerformance Performance { get; set; } = new();

	/// <summary>
	/// Onboarding
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "onboarding")]
	public WirelessClientHealthScoreOnboarding Onboarding { get; set; } = new();
}
