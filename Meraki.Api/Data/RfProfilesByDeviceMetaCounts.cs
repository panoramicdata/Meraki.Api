namespace Meraki.Api.Data;

/// <summary>
/// Rf Profiles By Device Meta Counts
/// </summary>
[ApiAccessReadOnlyClass]
[DataContract]
public class RfProfilesByDeviceMetaCounts
{
	/// <summary>
	/// The count metadata.
	/// </summary>
	[DataMember(Name = "items")]
	public RfProfilesByDeviceMetaCountsItems Items { get; set; } = new();
}
