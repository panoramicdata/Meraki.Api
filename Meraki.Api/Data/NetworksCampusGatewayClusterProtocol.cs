namespace Meraki.Api.Data;

[JsonConverter(typeof(StringEnumConverter))]
public enum NetworksCampusGatewayClusterProtocol
{
	[EnumMember(Value = "ipv4")]
	Ipv4
}