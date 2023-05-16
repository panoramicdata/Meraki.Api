namespace Meraki.Api.Data;

/// <summary>
/// A device for unsetting the switchProfileId
/// </summary>
public class DeviceForUnsettingTheSwitchProfileId : Device
{
	/// <summary>
	/// The ID of a switch profile to bind to the device (for available switch profiles, see the 'Switch Profiles' endpoint).
	/// Use null to unbind the switch device from the current profile. For a device to be bindable to a switch profile,
	/// it must (1) be a switch, and (2) belong to a network that is bound to a configuration template.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[ApiForeignKey(typeof(SwitchPortsStatuses))]
	[DataMember(Name = "switchProfileId")]
	[JsonProperty(NullValueHandling = NullValueHandling.Include)]
	public new string? SwitchProfileId { get; set; }
}
