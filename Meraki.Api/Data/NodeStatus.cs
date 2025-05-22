namespace Meraki.Api.Data;

/// <summary>
/// Node Status
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum NodeStatus
{
	/// <summary>
	/// Node is Offline
	/// </summary>
	[EnumMember(Value = "online")]
	Online,

	/// <summary>
	///  Node is Online
	/// </summary>
	[EnumMember(Value = "offline")]
	Offline,
}