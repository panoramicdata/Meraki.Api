namespace Meraki.Api.Data;

/// <summary>
/// Inventory devices
/// </summary>
[DataContract]
public class InventoryDevice
{
	/// <summary>
	/// Mac
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "mac")]
	public string Mac { get; set; } = string.Empty;

	/// <summary>
	/// Serial
	/// </summary>
	[ApiKey]
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// Name
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Model
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "model")]
	public string Model { get; set; } = string.Empty;

	/// <summary>
	/// Network ID
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "networkId")]
	public string NetworkId { get; set; } = string.Empty;

	/// <summary>
	/// Order number
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "orderNumber")]
	public string OrderNumber { get; set; } = string.Empty;

	/// <summary>
	/// Claimed at
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "claimedAt")]
	public string ClaimedAt { get; set; } = string.Empty;

	/// <summary>
	/// Tags
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "tags")]
	public List<string> Tags { get; set; } = new();

	/// <summary>
	/// Product Type
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "productType")]
	public ProductType ProductType { get; set; }
}
