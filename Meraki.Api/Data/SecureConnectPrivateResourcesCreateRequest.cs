namespace Meraki.Api.Data;

/// <summary>
/// Secure Connect Private Resources Create Request
/// </summary>
[DataContract]
public class SecureConnectPrivateResourcesCreateRequest
{
	/// <summary>
	/// Optional text description for a resource.
	/// </summary>
	[DataMember(Name = "description")]
	public string? Description { get; set; }

	/// <summary>
	/// Name of resource. This is required and should be unique across all resources for a given organization. Name cannot have any special characters other than spaces and hyphens.
	/// </summary>
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// List of resource group ids attached to this resource.
	/// </summary>
	[DataMember(Name = "resourceGroupIds")]
	public List<string> ResourceGroupIds { get; set; } = [];

	/// <summary>
	/// List of access types.
	/// </summary>
	[DataMember(Name = "accessTypes")]
	public List<SecureConnectPrivateResourcesCreateRequestAccessType> AccessTypes { get; set; } = [];

	/// <summary>
	/// List of resource addresses Protocols must be unique in this list.
	/// </summary>
	[DataMember(Name = "resourceAddresses")]
	public List<SecureConnectPrivateResourcesDataItemResourceAddress> ResourceAddresses { get; set; } = [];
}
