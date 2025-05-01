namespace Meraki.Api.Data;

/// <summary>
/// The network devices to be updated
/// </summary>
[DataContract]
public class NetworkFirmwareUpdateStagedEventsProducts
{
	/// <summary>
	/// The Switch network to be updated
	/// </summary>
	[DataMember(Name = "switch")]
	public NetworkFirmwareUpgradeStagedEventsSwitch? Switch { get; set; }
}