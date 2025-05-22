namespace Meraki.Api.Data;

/// <summary>
/// Secure Connect Private Resources Response
/// </summary>
[DataContract]
public class SecureConnectPrivateResourcesResponse
{
	/// <summary>
	/// Meta data details about result
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "meta")]
	public SecureConnectPrivateResourcesMetadata Meta { get; set; } = new();

	/// <summary>
	/// List of Private Resources
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "data")]
	public List<SecureConnectPrivateResourcesDataItem> Data { get; set; } = [];
}
