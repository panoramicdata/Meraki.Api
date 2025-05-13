namespace Meraki.Api.Data;

/// <summary>
/// Access type
/// </summary>
[DataContract]
public class SecureConnectPrivateResourcesCreateRequestAccessType
{
	/// <summary>
	/// Name of access type, network, browser or client.
	/// </summary>
	[DataMember(Name = "type")]
	public string Type { get; set; } = string.Empty;

	/// <summary>
	/// An array of addresses that the api automatically adds only for the client type.
	/// </summary>
	[DataMember(Name = "reachableAddresses")]
	public List<string>? ReachableAddresses { get; set; }
}