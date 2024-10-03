namespace Meraki.Api.Data;

public class ItemsResponseMeta
{
	/// <summary>
	///	Counts
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "counts")]
	public ItemsResponseMetaCounts? Counts { get; set; }
}
