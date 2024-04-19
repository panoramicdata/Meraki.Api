namespace Meraki.Api.Data;

/// <summary>
/// Ssids Statuses By Device Meta
/// </summary>
[DataContract]
public class SsidsStatusesByDeviceMeta
{
	/// <summary>
	/// Count metadata related to this result set.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "counts")]
	public SsidsStatusesByDeviceMetaCounts? Counts { get; set; } = new();
}
