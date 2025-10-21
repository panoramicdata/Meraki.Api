namespace Meraki.Api.Data;

/// <summary>
/// Wi-Fi allow lists for MAC
/// </summary>
[DataContract]
public class OrganizationWirelessMqttSettingsWifiAllowLists
{
	/// <summary>
	/// Allowed MAC list
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "macs")]
	public List<string>? Macs { get; set; }
}
