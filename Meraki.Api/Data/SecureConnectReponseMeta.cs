namespace Meraki.Api.Data;

/// <summary>
/// SecureConnectDestinationListsMeta
/// </summary>
[DataContract]
public class SecureConnectReponseMeta
{
	/// <summary>
	/// The maximum number of items that are returned on the page.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "limit")]
	public int Limit { get; set; }

	/// <summary>
	/// The number of the page in the collection.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "page")]
	public int Page { get; set; }

	/// <summary>
	/// The total number of items in the collection.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "total")]
	public int Total { get; set; }
}
