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
	[ApiAccess(ApiAccess.ReadWrite)]
	public NetworkFirmwareUpgradeStagedEventsSwitch? Switch { get; set; }

	/// <summary>
	/// The Catalyst Switch network to be updated
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "switchCatalyst")]
	public NetworkFirmwareUpgradeStagedEventsSwitch? SwitchCatalyst { get; set; }
}
