namespace Meraki.Api.Data;

/// <summary>
/// Client connections broken down by step
/// </summary>
[DataContract]
public class WirelessClientOnboardingHistoryClientCountsConnectionSteps
{
	/// <summary>
	/// Client connections at association stage
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "association")]
	public WirelessClientOnboardingHistoryClientCountsConnectionStepsAssociation Association { get; set; } = new();

	/// <summary>
	/// Client connections at auth stage
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "authentication")]
	public WirelessClientOnboardingHistoryClientCountsConnectionStepsAuthentication Authentication { get; set; } = new();

	/// <summary>
	/// Client connections at dhcp stage
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "dhcp")]
	public WirelessClientOnboardingHistoryClientCountsConnectionStepsDhcp Dhcp { get; set; } = new();

	/// <summary>
	/// Client connections at dns stage
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "dns")]
	public WirelessClientOnboardingHistoryClientCountsConnectionStepsDns Dns { get; set; } = new();
}
