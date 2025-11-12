namespace Meraki.Api.Data;

/// <summary>
/// A connection type
/// </summary>
[DataContract]
[JsonConverter(typeof(StringEnumConverter))]
public enum ConnectionType
{
	/// <summary>
	/// Wireless
	/// </summary>
	[EnumMember(Value = "Wireless")]
	Wireless = 1,


	/// <summary>
	/// Wired
	/// </summary>
	[EnumMember(Value = "Wired")]
	Wired
}
