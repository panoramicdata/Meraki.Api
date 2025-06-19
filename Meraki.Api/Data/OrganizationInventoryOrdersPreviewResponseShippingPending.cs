namespace Meraki.Api.Data;

/// <summary>
/// Order items still pending shipment data
/// </summary>
[DataContract]
public class OrganizationInventoryOrdersPreviewResponseShippingPending
{
	/// <summary>
	/// Remaining hardware items that are pending shipment
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "devices")]
	public List<OrganizationInventoryOrdersPreviewResponseShippingPendingDevice> Devices { get; set; } = [];
}
