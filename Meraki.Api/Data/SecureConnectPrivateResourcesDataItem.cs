namespace Meraki.Api.Data;

/// <summary>
/// A Private Resource
/// </summary>
[DataContract]
public class SecureConnectPrivateResourcesDataItem
{
	/// <summary>
	/// Certificate ID associated with this Private Resource
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "certificateId")]
	public string CertificateId { get; set; } = string.Empty;

	/// <summary>
	/// Creation time of the private resource
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "createdAt")]
	public string CreatedAt { get; set; } = string.Empty;

	/// <summary>
	/// Deletion time of the private resource, if applicable
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "deletedAt")]
	public string DeletedAt { get; set; } = string.Empty;

	/// <summary>
	/// Optional Text description for Resource
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "description")]
	public string Description { get; set; } = string.Empty;

	/// <summary>
	/// DNS Server ID associated with this Private Resource
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "dnsServerId")]
	public string DnsServerId { get; set; } = string.Empty;

	/// <summary>
	/// Name of Resource. This is required and should be unique across all Resources for a given organization. Name cannot have any special characters other than spaces and hyphens.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Organization ID associated with this Private Resource
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "organizationId")]
	public string OrganizationId { get; set; } = string.Empty;

	/// <summary>
	/// Private Resource resource ID, use this ID as reference for subsequent requests
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "resourceId")]
	public string ResourceId { get; set; } = string.Empty;

	/// <summary>
	/// Creation time of the umbrella application
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "umbrellaApplicationCreatedAt")]
	public string UmbrellaApplicationCreatedAt { get; set; } = string.Empty;

	/// <summary>
	/// Deletion time of the umbrella application, if applicable
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "umbrellaApplicationDeletedAt")]
	public string UmbrellaApplicationDeletedAt { get; set; } = string.Empty;

	/// <summary>
	/// Error message associated with the umbrella application, if any
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "umbrellaApplicationErrorMessage")]
	public string UmbrellaApplicationErrorMessage { get; set; } = string.Empty;

	/// <summary>
	/// Umbrella Application ID associated with this Private Resource
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "umbrellaApplicationId")]
	public string UmbrellaApplicationId { get; set; } = string.Empty;

	/// <summary>
	/// Last modified time of the umbrella application
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "umbrellaApplicationUpdatedAt")]
	public string UmbrellaApplicationUpdatedAt { get; set; } = string.Empty;

	/// <summary>
	/// Creation time of the umbrella resource
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "umbrellaResourceCreatedAt")]
	public string UmbrellaResourceCreatedAt { get; set; } = string.Empty;

	/// <summary>
	/// ID of the creator of the umbrella resource
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "umbrellaResourceCreatedBy")]
	public string UmbrellaResourceCreatedBy { get; set; } = string.Empty;

	/// <summary>
	/// Deletion time of the umbrella resource, if applicable
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "umbrellaResourceDeletedAt")]
	public string UmbrellaResourceDeletedAt { get; set; } = string.Empty;

	/// <summary>
	/// Error message associated with the umbrella resource, if any
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "umbrellaResourceErrorMessage")]
	public string UmbrellaResourceErrorMessage { get; set; } = string.Empty;

	/// <summary>
	/// Umbrella Resource ID associated with this Private Resource
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "umbrellaResourceId")]
	public string UmbrellaResourceId { get; set; } = string.Empty;

	/// <summary>
	/// ID of the last modifier of the umbrella resource
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "umbrellaResourceModifiedBy")]
	public string UmbrellaResourceModifiedBy { get; set; } = string.Empty;

	/// <summary>
	/// Last modified time of the umbrella resource
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "umbrellaResourceUpdatedAt")]
	public string UmbrellaResourceUpdatedAt { get; set; } = string.Empty;

	/// <summary>
	/// Last modified time of the private resource
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "updatedAt")]
	public string UpdatedAt { get; set; } = string.Empty;

	/// <summary>
	/// List of Resource group ids attached to this Private Resource
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "resourceGroupIds")]
	public List<string> ResourceGroupIds { get; set; } = [];

	/// <summary>
	/// List of access types
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "accessTypes")]
	public List<SecureConnectPrivateResourcesDataItemAccessType> AccessTypes { get; set; } = [];

	/// <summary>
	/// List of resource addresses Protocols must be unique in this list.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "resourceAddresses")]
	public List<SecureConnectPrivateResourcesDataItemResourceAddress> ResourceAddresses { get; set; } = [];
}
