namespace Meraki.Api.Data;

[JsonConverter(typeof(StringEnumConverter))]
public enum NetworksCampusGatewayClusterUplinkIPAddressAssignmentMode
{
	[EnumMember(Value = "static")]
	Static,

	[EnumMember(Value = "dynamic")]
	Dynamic
}