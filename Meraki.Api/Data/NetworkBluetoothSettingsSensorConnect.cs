namespace Meraki.Api.Data;

/// <summary>
/// Sensor Connect settings for network Bluetooth - Undocumented, observed in live API responses only
/// </summary>
[DataContract]
public class NetworkBluetoothSettingsSensorConnect
{
	/// <summary>
	/// Whether Sensor Connect is enabled
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }

	/// <summary>
	/// Sensor Connect scanning settings
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "scanning")]
	public NetworkBluetoothSettingsSensorConnectScanning? Scanning { get; set; }

	/// <summary>
	/// Sensor Connect advertising settings
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "advertising")]
	public NetworkBluetoothSettingsSensorConnectAdvertising? Advertising { get; set; }

	/// <summary>
	/// Sensor Connect filtering settings
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "filtering")]
	public NetworkBluetoothSettingsSensorConnectFiltering? Filtering { get; set; }

	/// <summary>
	/// The UUID used in the Sensor Connect beacon identifier
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "uuid")]
	public string? Uuid { get; set; }

	/// <summary>
	/// Sensor Connect major and minor assignment settings
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "assignment")]
	public NetworkBluetoothSettingsSensorConnectAssignment? Assignment { get; set; }

	/// <summary>
	/// The major number used in the beacon identifier
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "major")]
	public int? Major { get; set; }

	/// <summary>
	/// The minor number used in the beacon identifier
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "minor")]
	public int? Minor { get; set; }
}
