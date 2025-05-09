namespace Meraki.Api.Data;

/// <summary>
/// private application group for an Organization
/// </summary>
[DataContract]
public class SecureConnectPrivateApplicationGroup
{
	/// <summary>
	/// Application Group resource ID, use this ID as reference for subsequent requests
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "applicationGroupId")]
	public string ApplicationGroupId { get; set; } = string.Empty;

	/// <summary>
	/// Creation time of the private app group
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "createdAt")]
	public string CreatedAt { get; set; } = string.Empty;

	/// <summary>
	/// Text description for Application
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "description")]
	public string Description { get; set; } = string.Empty;

	/// <summary>
	/// Last modified time of the private app group
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "modifiedAt")]
	public string ModifiedAt { get; set; } = string.Empty;

	/// <summary>
	/// Application Group Name
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// List of application ids attached to this Private Application Group
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "applicationIds")]
	public List<string> ApplicationIds { get; set; } = [];
}