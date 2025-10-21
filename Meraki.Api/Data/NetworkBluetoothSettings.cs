namespace Meraki.Api.Data;

/// <summary>
/// UpdateNetworkBluetoothSettings
/// </summary>
[DataContract]
public class NetworkBluetoothSettings
{
	/// <summary>
	/// Whether APs will scan for Bluetooth enabled clients. (true, false)
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "scanningEnabled")]
	public bool ScanningEnabled { get; set; }

	/// <summary>
	/// Whether APs will advertise beacons. (true, false)
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "advertisingEnabled")]
	public bool AdvertisingEnabled { get; set; }

	/// <summary>
	/// eslMode - Undocumented
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "eslMode")]
	public string? EslMode { get; set; }

	/// <summary>
	/// The UUID to be used in the beacon identifier.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "uuid")]
	public string? Uuid { get; set; }

	/// <summary>
	/// Gets or Sets MajorMinorAssignmentMode
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "majorMinorAssignmentMode")]
	public MajorMinorAssignmentMode? MajorMinorAssignmentMode { get; set; }

	/// <summary>
	/// The major number to be used in the beacon identifier. Only valid in 'Non-unique' mode.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "major")]
	public int? Major { get; set; }

	/// <summary>
	/// The minor number to be used in the beacon identifier. Only valid in 'Non-unique' mode.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "minor")]
	public int? Minor { get; set; }

	/// <summary>
	/// Whether ESL is enabled on this network.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "eslEnabled")]
	public bool? EslEnabled { get; set; }

	/// <summary>
	/// Bluetooth transmit settings - Undocumented added 2025-10-21
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "transmit")]
	public NetworkBluetoothSettingsTransmit? Transmit { get; set; }
}
