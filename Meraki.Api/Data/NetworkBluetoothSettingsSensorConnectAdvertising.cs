namespace Meraki.Api.Data;

/// <summary>
/// Sensor Connect advertising settings - Undocumented, observed in live API responses only
/// </summary>
[DataContract]
public class NetworkBluetoothSettingsSensorConnectAdvertising
{
	/// <summary>
	/// Whether advertising is enabled
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }
}
