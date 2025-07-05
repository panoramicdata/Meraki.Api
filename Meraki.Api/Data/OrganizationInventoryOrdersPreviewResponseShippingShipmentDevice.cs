namespace Meraki.Api.Data;

/// <summary>
/// A device contained in this shipment
/// </summary>
[DataContract]
public class OrganizationInventoryOrdersPreviewResponseShippingShipmentDevice
{
	/// <summary>
	/// How many of this SKU are in this shipment
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "quantity")]
	public int Quantity { get; set; }

	/// <summary>
	/// The description of this device
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "description")]
	public string Description { get; set; } = string.Empty;

	/// <summary>
	/// The sku of this device
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "sku")]
	public string Sku { get; set; } = string.Empty;
}