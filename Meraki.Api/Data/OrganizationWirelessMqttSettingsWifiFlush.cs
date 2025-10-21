namespace Meraki.Api.Data;

/// <summary>
/// Wi-Fi flush settings
/// </summary>
[DataContract]
public class OrganizationWirelessMqttSettingsWifiFlush
{
	/// <summary>
	/// Wi-Fi Flush frequency in seconds. Will be between 1 and 2147483647. Default is 60 seconds
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "frequency")]
	public int? Frequency { get; set; }
}
