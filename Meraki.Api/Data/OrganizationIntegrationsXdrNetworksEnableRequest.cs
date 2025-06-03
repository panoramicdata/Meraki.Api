namespace Meraki.Api.Data;

/// <summary>
/// Organization Integrations XDR Networks Enable Request
/// </summary>
[DataContract]
public class OrganizationIntegrationsXdrNetworksEnableRequest
{
	/// <summary>
	/// List containing the network ID and the product type to enable XDR on
	/// </summary>
	[DataMember(Name = "networks")]
	public List<OrganizationIntegrationsXdrNetworksEnableRequestNetwork> Networks { get; set; } = [];
}
