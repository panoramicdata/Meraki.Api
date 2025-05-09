namespace Meraki.Api.Data;

/// <summary>
/// Destination target protocol and port for Private Applications
/// </summary>
[DataContract]
public class SecureConnectPrivateApplicationDestinationProtocolPort
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
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "protocol")]
	public string Protocol { get; set; } = string.Empty;
}