namespace Meraki.Api.Data;

[DataContract]
public class StaticRouteGateway
{
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "offset")]
	public StaticRouteGatewayOffset? Offset { get; set; }
}