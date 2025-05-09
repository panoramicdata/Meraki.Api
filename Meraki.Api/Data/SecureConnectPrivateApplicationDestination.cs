namespace Meraki.Api.Data;

/// <summary>
/// Destination target for Private Applications
/// </summary>
[DataContract]
public class SecureConnectPrivateApplicationDestination
{
	/// <summary>
	/// Browser Based Access or Network Based Access.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "accessType")]
	public string AccessType { get; set; } = string.Empty;

	/// <summary>
	/// IPv4 address and CIDR are allowed for Network Access Policy (accessType = network).Only /32 addresses are allowed for Browser Access Policy (accessType = browser).CIDR ranges are unsupported. IPv6 is unsupported.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "destinationAddr")]
	public List<string> DestinationAddr { get; set; } = [];

	/// <summary>
	/// List of protocols and ports for IP address destinations. Protocols must be unique in this list.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "protocolPorts")]
	public List<SecureConnectPrivateApplicationDestinationProtocolPort> ProtocolPorts { get; set; } = [];
}
