namespace Meraki.Api.Data;

/// <summary>
/// Sensor Connect ignore filter - Undocumented, observed in live API responses only
/// </summary>
[DataContract]
public class NetworkBluetoothSettingsSensorConnectFilteringIgnore
{
	/// <summary>
	/// MAC address based ignore filter
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "mac")]
	public NetworkBluetoothSettingsSensorConnectFilteringIgnoreMac? Mac { get; set; }
}
