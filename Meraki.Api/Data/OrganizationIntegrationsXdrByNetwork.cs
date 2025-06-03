namespace Meraki.Api.Data;

/// <summary>
/// Organization Integrations XDR By Network
/// </summary>
[DataContract]
public class OrganizationIntegrationsXdrByNetwork
{
	/// <summary>
	/// Metadata relevant to the paginated dataset
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "meta")]
	public OrganizationIntegrationsXdrMetadata Meta { get; set; } = new();

	/// <summary>
	/// List of networks with XDR enabled
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "items")]
	public List<OrganizationIntegrationsXdrItem> Items { get; set; } = [];
}
