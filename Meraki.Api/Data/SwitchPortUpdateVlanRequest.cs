namespace Meraki.Api.Data;

/// <summary>
/// A device switch port update request to change the VLAN settings.
/// </summary>
[DataContract]
public class SwitchPortUpdateVlanRequest
{
	/// <summary>
	/// The VLAN of the switch port. A null value will clear the value set for trunk ports.
	/// </summary>
	[DataMember(Name = "vlan")]
	[JsonProperty(NullValueHandling = NullValueHandling.Include)]
	public int? Vlan { get; set; }
}
