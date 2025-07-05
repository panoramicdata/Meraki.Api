namespace Meraki.Api.Data;

/// <summary>
/// Organization Integrations XDR Networks Enable Response
/// </summary>
[DataContract]
public class OrganizationIntegrationsXdrNetworksEnableResponse
{
	/// <summary>
	/// List of networks that have XDR enabled
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "networks")]
	public List<OrganizationIntegrationsXdrNetworksEnableResponseNetwork> Networks { get; set; } = [];
}
