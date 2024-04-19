namespace Meraki.Api.Data;

/// <summary>
/// Ssids Statuses By Device Item
/// </summary>
[DataContract]
public class SsidsStatusesByDeviceItem
{
	/// <summary>
	/// Name of device.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Unique serial number for device.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// Group of devices and settings.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "network")]
	public SsidsStatusesByDeviceItemNetwork Network { get; set; } = new();

	/// <summary>
	/// Status information for wireless access points.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "basicServiceSets")]
	public List<SsidsStatusesByDeviceItemBasicServiceSet> basicServiceSets { get; set; } = new();
}
