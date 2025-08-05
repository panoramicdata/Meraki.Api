namespace Meraki.Api.Data;

/// <summary>
/// All shipping information for this order
/// </summary>
[DataContract]
public class OrganizationInventoryOrdersPreviewResponseShipping
{
	/// <summary>
	/// Order items still pending shipment data
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "pending")]
	public OrganizationInventoryOrdersPreviewResponseShippingPending Pending { get; set; } = new();

	/// <summary>
	/// Hardware shipments for this order
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "shipments")]
	public List<OrganizationInventoryOrdersPreviewResponseShippingShipment> Shipments { get; set; } = [];
}
