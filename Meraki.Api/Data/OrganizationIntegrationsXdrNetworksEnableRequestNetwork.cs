namespace Meraki.Api.Data;

/// <summary>
/// Network containing the network ID and the product type to enable XDR on
/// </summary>
[DataContract]
public class OrganizationIntegrationsXdrNetworksEnableRequestNetwork
{
	/// <summary>
	/// Network ID
	/// </summary>
	[DataMember(Name = "networkId")]
	public string NetworkId { get; set; } = string.Empty;

	/// <summary>
	/// List of products for which to enable XDR
	/// </summary>
	[DataMember(Name = "productTypes")]
	public List<XdrProductType> ProductTypes { get; set; } = [];
}