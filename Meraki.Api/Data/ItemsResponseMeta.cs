namespace Meraki.Api.Data;

/// <summary>
/// Items Response Meta
/// </summary>
public class ItemsResponseMeta
{
	/// <summary>
	///	Counts
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "counts")]
	public ItemsResponseMetaCounts? Counts { get; set; }
}
