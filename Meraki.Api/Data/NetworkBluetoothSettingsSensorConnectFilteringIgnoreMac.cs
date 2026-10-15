namespace Meraki.Api.Data;

/// <summary>
/// Sensor Connect MAC address ignore filter - Undocumented, observed in live API responses only
/// </summary>
[DataContract]
public class NetworkBluetoothSettingsSensorConnectFilteringIgnoreMac
{
	/// <summary>
	/// MAC address types to ignore, for example 'random private'
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "addressTypes")]
	public List<string>? AddressTypes { get; set; }
}
