namespace Meraki.Api.Data;

/// <summary>
/// Private Application Groups
/// </summary>
[DataContract]
public class SecureConnectPrivateAppplicationGroups
{
	/// <summary>
	/// Meta data details about result
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "meta")]
	public SecureConnectPrivateAppplicationGroupsMetadata Meta { get; set; } = new();

	/// <summary>
	/// List of private application groups for an Organization
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "data")]
	public List<SecureConnectPrivateAppplicationGroup> Data { get; set; } = [];
}
