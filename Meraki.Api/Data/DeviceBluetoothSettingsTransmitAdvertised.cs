namespace Meraki.Api.Data;

/// <summary>
/// Advertised transmit settings for device Bluetooth beacon
/// </summary>
[DataContract]
public class DeviceBluetoothSettingsTransmitAdvertised
{
	/// <summary>
	/// Advertised transmit power (null to use network default)
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "power")]
	public int? Power { get; set; }
}
