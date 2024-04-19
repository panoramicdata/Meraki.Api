namespace Meraki.Api.Data;

/// <summary>
/// Ssids Statuses By Device
/// </summary>
[DataContract]
public class SsidsStatusesByDevice
{
	/// <summary>
	/// Other metadata related to this result set.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "meta")]
	public SsidsStatusesByDeviceMeta? Meta { get; set; } = new();

	/// <summary>
	/// The top-level property containing all status data.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public List<SsidsStatusesByDeviceItem> Items { get; set; } = new();
}
