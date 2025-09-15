namespace Meraki.Api.Data;

/// <summary>
/// The switch network settings
/// </summary>
[DataContract]
public class SwitchSettings
{
	/// <summary>
	/// Management VLAN
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "vlan")]
	public int? Vlan { get; set; }

	/// <summary>
	/// The use Combined Power as the default behavior of secondary power supplies on supported devices.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "useCombinedPower")]
	public bool? UseCombinedPower { get; set; }

	/// <summary>
	/// Exceptions on a per switch basis to 'useCombinedPower'
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "powerExceptions")]
	public List<PowerException>? PowerExceptions { get; set; }

	/// <summary>
	/// Uplink Client Sampling - Undocumented
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "uplinkClientSampling")]
	public SwitchSettingsUplinkClientSampling? UplinkClientSampling { get; set; }

	/// <summary>
	/// Undocumented macBlockList added 2023-08-25
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "macBlocklist")]
	public MacBlockListSettings? MacBlockList { get; set; }

	/// <summary>
	/// Undocumented uacSettings
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "uacSettings")]
	public SwitchSettingsUacSettings? UacSettings { get; set; }

	/// <summary>
	/// Undocumented uacAutomaticFailback
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "uacAutomaticFailback")]
	public SwitchSettingsUacAutomaticFailback? UacAutomaticFailback { get; set; }
}
