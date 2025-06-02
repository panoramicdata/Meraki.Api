namespace Meraki.Api.Data;

/// <summary>
/// Status count by product type
/// </summary>
[DataContract]
public class NetworkStatusSummaryStatusesByProductTypeItem
{
	/// <summary>
	/// Product type
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "productType")]
	public string ProductType { get; set; } = string.Empty;

	/// <summary>
	/// Counts of devices by status
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "counts")]
	public NetworkStatusSummaryStatusesByProductTypeItemCounts Counts { get; set; } = new();
}
