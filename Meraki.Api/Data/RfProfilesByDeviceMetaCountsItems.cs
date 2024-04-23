namespace Meraki.Api.Data;

/// <summary>
/// Rf Profiles By Device Meta Counts Items
/// </summary>
[ApiAccessReadOnlyClass]
[DataContract]
public class RfProfilesByDeviceMetaCountsItems
{
	/// <summary>
	/// The number of serials remaining based on current pagination location within the dataset.
	/// </summary>
	[DataMember(Name = "remaining")]
	public int Remaining { get; set; }

	/// <summary>
	/// The total number of serials.
	/// </summary>
	[DataMember(Name = "total")]
	public int Total { get; set; }

}
