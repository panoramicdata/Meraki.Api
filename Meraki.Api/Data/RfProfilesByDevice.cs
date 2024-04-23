namespace Meraki.Api.Data;

/// <summary>
/// Rf Profiles By Device
/// </summary>
[ApiAccessReadOnlyClass]
[DataContract]
public class RfProfilesByDevice
{
	/// <summary>
	/// Other metadata related to this result set.
	/// </summary>
	[DataMember(Name = "meta")]
	public RfProfilesByDeviceMeta Meta { get; set; } = new();

	/// <summary>
	/// The top-level property containing all status data.
	/// </summary>
	[DataMember(Name = "items")]
	public List<RfProfilesByDeviceItem> Items { get; set; } = [];
}
