namespace Meraki.Api.Data;

/// <summary>
/// Protocol and port information for IP address destination
/// </summary>
[DataContract]
public class SecureConnectPrivateResourcesDataItemResourceAddressProtocolPort
{
	/// <summary>
	/// Port for connecting with Application Upstream. Comma separated ports and port ranges are allowed. Port number must be in between 1-65535.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "ports")]
	public string Ports { get; set; } = string.Empty;

	/// <summary>
	/// Protocol for connecting with Application Upstream. Only TCP protocol is allowed for Browser Based Access.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "protocol")]
	public string Protocol { get; set; } = string.Empty;
}