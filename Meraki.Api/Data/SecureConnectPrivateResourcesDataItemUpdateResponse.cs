namespace Meraki.Api.Data;

/// <summary>
/// Secure Connect Private Resources Update Response
/// </summary>
[DataContract]
public class SecureConnectPrivateResourcesDataItemUpdateResponse
{
	/// <summary>
	/// List of Private Resource Groups
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "data")]
	public List<SecureConnectPrivateResourceGroupDataItem> Data { get; set; } = [];
}
