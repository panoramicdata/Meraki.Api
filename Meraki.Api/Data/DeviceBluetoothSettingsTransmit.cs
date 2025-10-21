namespace Meraki.Api.Data;

/// <summary>
/// Bluetooth transmit settings for device
/// </summary>
[DataContract]
public class DeviceBluetoothSettingsTransmit
{
	/// <summary>
	/// Transmit power level (null to use network default)
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "power")]
	public int? Power { get; set; }

	/// <summary>
	/// Transmit interval in milliseconds (null to use network default)
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "interval")]
	public int? Interval { get; set; }

	/// <summary>
	/// Advertised settings for beacon
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "advertised")]
	public DeviceBluetoothSettingsTransmitAdvertised? Advertised { get; set; }
}
