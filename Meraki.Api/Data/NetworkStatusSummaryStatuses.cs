namespace Meraki.Api.Data;

/// <summary>
/// Network device statuses
/// </summary>
[DataContract]
public class NetworkStatusSummaryStatuses
{
	/// <summary>
	/// Overall status of network
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "overall")]
	public string Overall { get; set; } = string.Empty;

	/// <summary>
	/// List of status counts by product type
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "byProductType")]
	public List<NetworkStatusSummaryStatusesByProductTypeItem> ByProductType { get; set; } = [];
}
