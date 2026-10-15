namespace Meraki.Api.Data;

/// <summary>
/// Sensor Connect scanning settings - Undocumented, observed in live API responses only
/// </summary>
[DataContract]
public class NetworkBluetoothSettingsSensorConnectScanning
{
	/// <summary>
	/// Whether scanning is enabled
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }
}
