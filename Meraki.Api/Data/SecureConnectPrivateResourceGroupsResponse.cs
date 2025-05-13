namespace Meraki.Api.Data;

/// <summary>
/// Secure Connect Private Resource Groups Response
/// </summary>
[DataContract]
public class SecureConnectPrivateResourceGroupsResponse
{
	/// <summary>
	/// List of Private Resource Groups
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "data")]
	public List<SecureConnectPrivateResourceGroupDataItem> Data { get; set; } = [];
}
