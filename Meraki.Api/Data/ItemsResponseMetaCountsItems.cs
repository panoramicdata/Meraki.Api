namespace Meraki.Api.Data;

/// <summary>
/// Items Response Meta Counts Items
/// </summary>
public class ItemsResponseMetaCountsItems
{
	/// <summary>
	///	Remaining number of Items
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "remaining")]
	public int? Remaining { get; set; }

	/// <summary>
	///	Total number of Items
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "total")]
	public int? Total { get; set; }
}
