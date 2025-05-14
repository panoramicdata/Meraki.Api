namespace Meraki.Api.Data;

/// <summary>
/// Secure Connect Private Resources Update Request
/// </summary>
[DataContract]
public class SecureConnectPrivateResourcesUpdateRequest
{
	/// <summary>
	/// Optional text description for a group.
	/// </summary>
	[DataMember(Name = "description")]
	public string? Description { get; set; }

	/// <summary>
	/// Name of group. This is required and should be unique across all groups for a given organization. Name cannot have any special characters other than spaces and hyphens.
	/// </summary>
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// List of resource ids assigned to this group.
	/// </summary>
	[DataMember(Name = "resourceIds")]
	public List<string>? ResourceIds { get; set; }
}
