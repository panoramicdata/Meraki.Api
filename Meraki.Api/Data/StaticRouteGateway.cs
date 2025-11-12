namespace Meraki.Api.Data;

/// <summary>
/// Static Route Gateway
/// </summary>
[DataContract]
public class StaticRouteGateway
{
	/// <summary>
	/// Gets the offset
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "offset")]
	public StaticRouteGatewayOffset? Offset { get; set; }
}
