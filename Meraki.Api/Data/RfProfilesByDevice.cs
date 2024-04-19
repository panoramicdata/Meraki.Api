namespace Meraki.Api.Data;

/// <summary>
/// Rf Profiles By Device
/// </summary>
[DataContract]
public class RfProfilesByDevice
{
	/// <summary>
	/// Other metadata related to this result set.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "meta")]
	public RfProfilesByDeviceMeta Meta { get; set; } = new();

	/// <summary>
	/// The top-level property containing all status data.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public List<RfProfilesByDeviceItem> Items { get; set; } = new();
}
