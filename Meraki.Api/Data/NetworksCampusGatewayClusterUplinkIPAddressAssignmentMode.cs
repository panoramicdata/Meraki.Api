namespace Meraki.Api.Data;

/// <summary>
/// Networks Campus Gateway Cluster Uplink IP Address Assignment Mode
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum NetworksCampusGatewayClusterUplinkIPAddressAssignmentMode
{
	/// <summary>
	/// Static
	/// </summary>
	[EnumMember(Value = "static")]
	Static,

	/// <summary>
	/// Dynamic
	/// </summary>
	[EnumMember(Value = "dynamic")]
	Dynamic
}
