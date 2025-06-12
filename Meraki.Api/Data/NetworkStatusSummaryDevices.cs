namespace Meraki.Api.Data;

/// <summary>
/// Network device information
/// </summary>
[DataContract]
public class NetworkStatusSummaryDevices
{
	/// <summary>
	/// URLs by product type
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "byProductType")]
	public List<NetworkStatusSummaryDevicesByProductTypeItem> ByProductType { get; set; } = [];
}
