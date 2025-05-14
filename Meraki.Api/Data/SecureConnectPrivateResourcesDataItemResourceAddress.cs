namespace Meraki.Api.Data;

/// <summary>
/// Resource addresses Protocol information
/// </summary>
[DataContract]
public class SecureConnectPrivateResourcesDataItemResourceAddress
{
	/// <summary>
	/// Addresses in fqdn, ip or cidr format
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "destinationAddr")]
	public List<string> DestinationAddresses { get; set; } = [];

	/// <summary>
	/// List of protocols and ports for IP address destinations. Protocols must be unique in this list.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "protocolPorts")]
	public List<SecureConnectPrivateResourcesDataItemResourceAddressProtocolPort> ProtocolPorts { get; set; } = [];
}
