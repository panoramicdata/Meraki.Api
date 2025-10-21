namespace Meraki.Api.Data;

/// <summary>
/// BLE hysteresis settings
/// </summary>
[DataContract]
public class OrganizationWirelessMqttSettingsBleHysteresis
{
	/// <summary>
	/// BLE Hysteresis Enabled
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }

	/// <summary>
	/// BLE Threshold. Will be between 1 and 2147483647. Default is 1 second
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "threshold")]
	public int? Threshold { get; set; }
}
