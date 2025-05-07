namespace Meraki.Api.Data;

/// <summary>
/// The Switch network to be updated
/// </summary>
[DataContract]
public class NetworkFirmwareUpgradeStagedEventsSwitch
{
	/// <summary>
	/// Details of the next firmware upgrade
	/// </summary>
	[DataMember(Name = "nextUpgrade")]
	[ApiAccess(ApiAccess.Read)]
	public NetworkFirmwareUpgradeStagedEventsSwitchNextUpgrade? NextUpgrade { get; set; }
}