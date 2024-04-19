namespace Meraki.Api.Data;

/// <summary>
/// Ssids Statuses By Device Meta Counts
/// </summary>
[DataContract]
public class SsidsStatusesByDeviceMetaCounts
{
	/// <summary>
	/// The count metadata.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public SsidsStatusesByDeviceMetaCountsItems? Items { get; set; } = new();
}
