namespace Meraki.Api.Data;

/// <summary>
/// URL and product type
/// </summary>
[DataContract]
public class NetworkStatusSummaryDevicesByProductTypeItem
{
	/// <summary>
	/// Product type
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "productType")]
	public string ProductType { get; set; } = string.Empty;

	/// <summary>
	/// URL to clients list for the relevant product type
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "url")]
	public string Url { get; set; } = string.Empty;
}