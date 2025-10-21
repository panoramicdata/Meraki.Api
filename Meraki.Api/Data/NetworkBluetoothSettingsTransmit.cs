namespace Meraki.Api.Data;

/// <summary>
/// Bluetooth transmit settings for network
/// </summary>
[DataContract]
public class NetworkBluetoothSettingsTransmit
{
	/// <summary>
	/// Transmit power level
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "power")]
	public int? Power { get; set; }

	/// <summary>
	/// Transmit interval in milliseconds
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "interval")]
	public int? Interval { get; set; }

	/// <summary>
	/// Advertised settings for beacon
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "advertised")]
	public NetworkBluetoothSettingsTransmitAdvertised? Advertised { get; set; }
}
