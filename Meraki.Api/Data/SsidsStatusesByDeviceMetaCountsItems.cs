namespace Meraki.Api.Data;

/// <summary>
/// Ssids Statuses By Device Meta Counts Items
/// </summary>
[ApiAccessReadOnlyClass]
[DataContract]
public class SsidsStatusesByDeviceMetaCountsItems
{
	/// <summary>
	/// The number of items remaining based on current pagination location within the dataset.
	/// </summary>
	[DataMember(Name = "remaining")]
	public int Remaining { get; set; }

	/// <summary>
	/// The total number of items.
	/// </summary>
	[DataMember(Name = "total")]
	public int Total { get; set; }
}
