namespace Meraki.Api.Data;

/// <summary>
/// Fast PoE settings for the switch port
/// </summary>
[DataContract]
public class SwitchPortFastPoe
{
	/// <summary>
	/// Whether Fast PoE is enabled. Fast PoE requires Perpetual PoE to be enabled. This field is returned for all physical switch ports, but can only be enabled on ports that support PoE HA.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }
}
