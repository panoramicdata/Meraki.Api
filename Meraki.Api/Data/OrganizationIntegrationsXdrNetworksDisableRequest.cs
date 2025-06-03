namespace Meraki.Api.Data;

/// <summary>
/// Organization Integrations XDR Networks Disable Request
/// </summary>
[DataContract]
public class OrganizationIntegrationsXdrNetworksDisableRequest
{
	/// <summary>
	/// List containing the network ID and the product type to disable XDR on
	/// </summary>
	[DataMember(Name = "networks")]
	public List<OrganizationIntegrationsXdrNetworksDisableRequestNetwork> Networks { get; set; } = [];
}
