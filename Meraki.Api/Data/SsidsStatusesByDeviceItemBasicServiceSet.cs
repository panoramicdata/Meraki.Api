namespace Meraki.Api.Data;

/// <summary>
/// Ssids Statuses By Device Item Basic Service Set
/// </summary>
[ApiAccessReadOnlyClass]
[DataContract]
public class SsidsStatusesByDeviceItemBasicServiceSet
{
	/// <summary>
	/// Unique identifier for wireless access point.
	/// </summary>
	[DataMember(Name = "bssid")]
	public string Bssid { get; set; } = string.Empty;

	/// <summary>
	/// Wireless access point radio identifier.
	/// </summary>
	[DataMember(Name = "radio")]
	public SsidsStatusesByDeviceItemBasicServiceSetRadio Radio { get; set; } = new();

	/// <summary>
	/// Wireless access point and network identifier.
	/// </summary>
	[DataMember(Name = "ssid")]
	public SsidsStatusesByDeviceItemBasicServiceSetSsid Ssid { get; set; } = new();
}
