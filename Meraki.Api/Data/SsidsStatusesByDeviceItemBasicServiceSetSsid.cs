namespace Meraki.Api.Data;

/// <summary>
/// Ssids Statuses By Device Item Basic Service Set Ssid
/// </summary>
[ApiAccessReadOnlyClass]
[DataContract]
public class SsidsStatusesByDeviceItemBasicServiceSetSsid
{
	/// <summary>
	/// Unique identifier for wireless network.
	/// </summary>
	[DataMember(Name = "number")]
	public int Number { get; set; }

	/// <summary>
	/// Name of wireless network.
	/// </summary>
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Availability of wireless network for devices to connect to.
	/// </summary>
	[DataMember(Name = "advertised")]
	public bool Advertised { get; set; }

	/// <summary>
	/// Status of wireless network.
	/// </summary>
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }
}
