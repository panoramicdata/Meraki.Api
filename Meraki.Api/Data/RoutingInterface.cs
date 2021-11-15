namespace Meraki.Api.Data;

/// <summary>
/// Routing interface
/// </summary>
[DataContract]
public class RoutingInterface : RoutingInterfaceCreateRequest
{
	/// <summary>
	/// Interface Id
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "interfaceId")]
	public string InterfaceId { get; set; } = string.Empty;
}
