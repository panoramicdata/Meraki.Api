namespace Meraki.Api.Data;

/// <summary>
/// Preferred uplink for an uplink preference rule
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum PreferredUplink
{
	/// <summary>
	/// Enum Wan1 for "wan1"
	/// </summary>
	[EnumMember(Value = "wan1")]
	Wan1 = 1,

	/// <summary>
	/// Enum Wan2 for "wan2"
	/// </summary>
	[EnumMember(Value = "wan2")]
	Wan2,

	/// <summary>
	/// Enum BestForVoIP for "bestForVoIP"
	/// </summary>
	[EnumMember(Value = "bestForVoIP")]
	BestForVoIP,

	/// <summary>
	/// Enum LoadBalancing for "loadBalancing"
	/// </summary>
	[EnumMember(Value = "loadBalancing")]
	LoadBalancing,

	/// <summary>
	/// Enum DefaultUplink for "defaultUplink"
	/// </summary>
	[EnumMember(Value = "defaultUplink")]
	DefaultUplink,
}
