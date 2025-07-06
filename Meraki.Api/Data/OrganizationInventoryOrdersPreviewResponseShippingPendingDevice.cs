namespace Meraki.Api.Data;

/// <summary>
/// Hardware items that are pending shipment
/// </summary>
[DataContract]
public class OrganizationInventoryOrdersPreviewResponseShippingPendingDevice
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
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "description")]
	public string Description { get; set; } = string.Empty;

	/// <summary>
	/// The sku of this device
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "sku")]
	public string Sku { get; set; } = string.Empty;
}