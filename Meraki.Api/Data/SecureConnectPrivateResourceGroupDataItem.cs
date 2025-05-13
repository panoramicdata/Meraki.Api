namespace Meraki.Api.Data;

/// <summary>
/// Private Resource Group
/// </summary>
[DataContract]
public class SecureConnectPrivateResourceGroupDataItem
{
	/// <summary>
	/// Creation time of the private resource group
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "createdAt")]
	public string CreatedAt { get; set; } = string.Empty;

	/// <summary>
	/// Text description for resource
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "description")]
	public string Description { get; set; } = string.Empty;

	/// <summary>
	/// Resource Group Name.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Private Resource group ID, use this ID as reference for subsequent requests
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "resourceGroupId")]
	public string ResourceGroupId { get; set; } = string.Empty;

	/// <summary>
	/// Last modified time of the private resource group
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "updatedAt")]
	public string UpdatedAt { get; set; } = string.Empty;

	/// <summary>
	/// List of resource ids attached to this private resource group
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "resourceIds")]
	public List<string> ResourceIds { get; set; } = [];
}
