namespace Meraki.Api.Data;

/// <summary>
/// Advertised transmit settings for Bluetooth beacon
/// </summary>
[DataContract]
public class NetworkBluetoothSettingsTransmitAdvertised
{
	/// <summary>
	/// Advertised transmit power
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "power")]
	public int? Power { get; set; }
}
