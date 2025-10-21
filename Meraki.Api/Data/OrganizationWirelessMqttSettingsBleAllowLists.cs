namespace Meraki.Api.Data;

/// <summary>
/// BLE allow lists for UUID and MAC
/// </summary>
[DataContract]
public class OrganizationWirelessMqttSettingsBleAllowLists
{
	/// <summary>
	/// Allowed UUID list
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "uuids")]
	public List<string>? Uuids { get; set; }

	/// <summary>
	/// Allowed MAC list
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "macs")]
	public List<string>? Macs { get; set; }
}
