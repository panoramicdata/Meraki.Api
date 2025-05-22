namespace Meraki.Api.Data;

/// <summary>
/// Access type
/// </summary>
[DataContract]
public class SecureConnectPrivateResourcesDataItemAccessType
{
	/// <summary>
	/// Name of access type, network, browser or client.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "type")]
	public string Type { get; set; } = string.Empty;

	/// <summary>
	/// An array of addresses that the api automatically adds for the client type.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "reachableAddresses")]
	public List<string> ReachableAddresses { get; set; } = [];
}