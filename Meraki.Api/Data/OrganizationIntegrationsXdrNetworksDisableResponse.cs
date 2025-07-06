namespace Meraki.Api.Data;

/// <summary>
/// Organization Integrations XDR Networks Disable Response
/// </summary>
[DataContract]
public class OrganizationIntegrationsXdrNetworksDisableResponse
{
	/// <summary>
	/// List of networks that have XDR disabled
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "networks")]
	public List<OrganizationIntegrationsXdrNetworksDisableResponseNetwork> Networks { get; set; } = [];
}
