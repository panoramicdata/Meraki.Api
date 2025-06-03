namespace Meraki.Api.Data;

/// <summary>
/// Contains the network ID and product type to disable XDR on
/// </summary>
[DataContract]
public class OrganizationIntegrationsXdrNetworksDisableRequestNetwork
{
	/// <summary>
	/// Network ID
	/// </summary>
	[DataMember(Name = "networkId")]
	public string NetworkId { get; set; } = string.Empty;

	/// <summary>
	/// List of products for which to disable XDR
	/// </summary>
	[DataMember(Name = "productTypes")]
	public List<XdrProductType> ProductTypes { get; set; } = [];
}
