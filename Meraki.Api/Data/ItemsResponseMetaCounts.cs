namespace Meraki.Api.Data;

public class ItemsResponseMetaCounts
{
	/// <summary>
	///	Item counts
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public ItemsResponseMetaCountsItems Items { get; set; } = new();
}
