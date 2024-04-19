namespace Meraki.Api.Data;

/// <summary>
/// Ssids Statuses By Device Meta Counts Items
/// </summary>
[DataContract]
public class SsidsStatusesByDeviceMetaCountsItems
{
	/// <summary>
	/// The number of items remaining based on current pagination location within the dataset.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "remaining")]
	public int Remaining { get; set; }

	/// <summary>
	/// The total number of items.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "total")]
	public int Total { get; set; }
}
