namespace Meraki.Api.Data;

/// <summary>
/// Secure Connect Private Application Group Update Request
/// </summary>
[DataContract]
public class SecureConnectPrivateApplicationGroupUpdateRequest
{
	/// <summary>
	/// Optional short description for application group
	/// </summary>
	[DataMember(Name = "description")]
	public string? Description { get; set; }
	/// <summary>
	/// Application Group Name. This is required and cannot have any special characters other than spaces and hyphens
	/// </summary>
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;
	/// <summary>
	/// List of application ids attached to this Private Application Group
	/// </summary>
	[DataMember(Name = "applicationIds")]
	public List<string>? ApplicationIds { get; set; }
}
