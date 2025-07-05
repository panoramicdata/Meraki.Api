namespace Meraki.Api.Data;

/// <summary>
/// Session filter item
/// </summary>
[DataContract]
public class OrganizationsNacSessionsHistoryMetadataCountsItemsByResultItem
{
	/// <summary>
	/// Total Sessions under filter
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "total")]
	public int Total { get; set; }

	/// <summary>
	/// Result of Session filter
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "result")]
	public string Result { get; set; } = string.Empty;
}