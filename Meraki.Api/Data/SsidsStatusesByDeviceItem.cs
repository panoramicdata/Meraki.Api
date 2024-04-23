namespace Meraki.Api.Data;

/// <summary>
/// Ssids Statuses By Device Item
/// </summary>
[ApiAccessReadOnlyClass]
[DataContract]
public class SsidsStatusesByDeviceItem
{
	/// <summary>
	/// Name of device.
	/// </summary>
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Unique serial number for device.
	/// </summary>
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// Group of devices and settings.
	/// </summary>
	[DataMember(Name = "network")]
	public SsidsStatusesByDeviceItemNetwork Network { get; set; } = new();

	/// <summary>
	/// Status information for wireless access points.
	/// </summary>
	[DataMember(Name = "basicServiceSets")]
	public List<SsidsStatusesByDeviceItemBasicServiceSet> basicServiceSets { get; set; } = [];
}
