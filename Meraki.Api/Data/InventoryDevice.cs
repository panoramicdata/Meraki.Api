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
	public string? Mac { get; set; }

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
	public string? Name { get; set; }

	/// <summary>
	/// Model
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "model")]
	public string? Model { get; set; }

	/// <summary>
	/// Network ID
	/// </summary>
	[ApiForeignKey(typeof(Network))]
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "networkId")]
	public string? NetworkId { get; set; }

	/// <summary>
	/// Order number
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "orderNumber")]
	public string? OrderNumber { get; set; }

	/// <summary>
	/// Claimed at
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "claimedAt")]
	public DateTime? ClaimedAt { get; set; }

	/// <summary>
	/// Tags
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "tags")]
	public List<string>? Tags { get; set; }

	/// <summary>
	/// Claimed at
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "licenseExpirationDate")]
	public DateTime? LicenseExpirationDate { get; set; }

	/// <summary>
	/// Product Type
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "productType")]
	public ProductType? ProductType { get; set; }

	/// <summary>
	/// Country Code - Undocumented 2023-09-05
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "countryCode")]
	public string? CountryCode { get; set; }

	/// <summary>
	/// Usage - Undocumented 2023-10-03
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "usage")]
	public string? Usage { get; set; }

	/// <summary>
	/// Device Details
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "details")]
	public List<DeviceDetail>? Details { get; set; }

	/// <summary>
	/// Born As
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "bornAs")]
	public string? BornAs { get; set; }

	/// <summary>
	/// End of life status - Undocumented added 2025-10-21
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "eoxStatus")]
	public string? EoxStatus { get; set; }

	/// <summary>
	/// End of sale date - Undocumented added 2025-10-21
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "endOfSaleAt")]
	public DateTime? EndOfSaleAt { get; set; }

	/// <summary>
	/// End of support date - Undocumented added 2025-10-21
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "endOfSupportAt")]
	public DateTime? EndOfSupportAt { get; set; }
}
