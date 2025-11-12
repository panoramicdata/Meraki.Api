namespace Meraki.Api.Data;

/// <summary>
/// A connection type
/// </summary>
[DataContract]
[JsonConverter(typeof(StringEnumConverter))]
public enum ConnectionType
{
	[EnumMember(Value = "Wireless")]
	/// <summary>
	/// Wireless
	/// </summary>
	Wireless = 1,

	[EnumMember(Value = "Wired")]
	/// <summary>
	/// Wired
	/// </summary>
	Wired
}
