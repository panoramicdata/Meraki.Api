namespace Meraki.Api.Data;

/// <summary>
/// Ssids Statuses By Device Meta
/// </summary>
[ApiAccessReadOnlyClass]
[DataContract]
public class SsidsStatusesByDeviceMeta
{
	/// <summary>
	/// Count metadata related to this result set.
	/// </summary>
	[DataMember(Name = "counts")]
	public SsidsStatusesByDeviceMetaCounts? Counts { get; set; } = new();
}
