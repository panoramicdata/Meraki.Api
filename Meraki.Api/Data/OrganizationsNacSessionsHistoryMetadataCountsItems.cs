namespace Meraki.Api.Data;

/// <summary>
/// Object for Total RADIUS Sessions
/// </summary>
[DataContract]
public class OrganizationsNacSessionsHistoryMetadataCountsItems
{
	/// <summary>
	/// Total RADIUS Sessions
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "total")]
	public int Total { get; set; }

	/// <summary>
	/// List of session filters
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "byResult")]
	public List<OrganizationsNacSessionsHistoryMetadataCountsItemsByResultItem> ByResult { get; set; } = [];
}
