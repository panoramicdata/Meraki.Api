namespace Meraki.Api.Data;

/// <summary>
/// A Network device to be updated
/// </summary>
[DataContract]
public class NetworkFirmwareUpgradeStagedEventsProduct
{
	/// <summary>
	/// The Switch network to be updated
	/// </summary>
	[DataMember(Name = "switch")]
	public NetworkFirmwareUpgradeStagedEventsSwitch? Switch { get; set; }
}
