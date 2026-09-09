namespace Meraki.Api.Data;

/// <summary>
/// Perpetual PoE settings for the switch port
/// </summary>
[DataContract]
public class SwitchPortPerpetualPoe
{
	/// <summary>
	/// Whether Perpetual PoE is enabled. This field is returned for all physical switch ports, but can only be enabled on ports that support PoE HA.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }
}
