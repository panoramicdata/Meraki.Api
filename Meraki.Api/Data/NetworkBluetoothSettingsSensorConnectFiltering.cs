namespace Meraki.Api.Data;

/// <summary>
/// Sensor Connect filtering settings - Undocumented, observed in live API responses only
/// </summary>
[DataContract]
public class NetworkBluetoothSettingsSensorConnectFiltering
{
	/// <summary>
	/// Filtering rules for devices to ignore
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ignore")]
	public NetworkBluetoothSettingsSensorConnectFilteringIgnore? Ignore { get; set; }
}
