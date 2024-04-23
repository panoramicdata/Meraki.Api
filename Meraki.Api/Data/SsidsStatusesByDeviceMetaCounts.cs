namespace Meraki.Api.Data;

/// <summary>
/// Ssids Statuses By Device Meta Counts
/// </summary>
[ApiAccessReadOnlyClass]
[DataContract]
public class SsidsStatusesByDeviceMetaCounts
{
	/// <summary>
	/// The count metadata.
	/// </summary>
	[DataMember(Name = "items")]
	public SsidsStatusesByDeviceMetaCountsItems? Items { get; set; } = new();
}
