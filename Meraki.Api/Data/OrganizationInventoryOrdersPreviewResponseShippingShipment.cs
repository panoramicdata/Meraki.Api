namespace Meraki.Api.Data;

/// <summary>
/// Hardware shipment for this order
/// </summary>
[DataContract]
public class OrganizationInventoryOrdersPreviewResponseShippingShipment
{
	/// <summary>
	/// Which shipment the information is for
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "number")]
	public int Number { get; set; }

	/// <summary>
	/// The date this shipment was shipped
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "shippedAt")]
	public string ShippedAt { get; set; } = string.Empty;

	/// <summary>
	/// All devices contained in this shipment
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "devices")]
	public List<OrganizationInventoryOrdersPreviewResponseShippingShipmentDevice> Devices { get; set; } = [];
}
