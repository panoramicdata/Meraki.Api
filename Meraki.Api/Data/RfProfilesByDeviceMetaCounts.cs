namespace Meraki.Api.Data;

/// <summary>
/// Rf Profiles By Device Meta Counts
/// </summary>
[DataContract]
public class RfProfilesByDeviceMetaCounts
{
	/// <summary>
	/// The count metadata.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public RfProfilesByDeviceMetaCountsItems Items { get; set; } = new();

}
