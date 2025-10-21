namespace Meraki.Api.Data;

/// <summary>
/// BLE flush settings
/// </summary>
[DataContract]
public class OrganizationWirelessMqttSettingsBleFlush
{
	/// <summary>
	/// BLE Flush frequency in seconds. Will be between 1 and 2147483647. Default is 60 seconds
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "frequency")]
	public int? Frequency { get; set; }
}
