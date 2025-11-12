namespace Meraki.Api.Data;

/// <summary>
/// Networks Campus Gateway Cluster Uplink IP Address Assignment Mode
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum NetworksCampusGatewayClusterUplinkIPAddressAssignmentMode
{
	[EnumMember(Value = "static")]
	/// <summary>
	/// Static
	/// </summary>
	Static,

	[EnumMember(Value = "dynamic")]
	/// <summary>
	/// Dynamic
	/// </summary>
	Dynamic
}
