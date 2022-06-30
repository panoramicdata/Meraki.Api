namespace Meraki.Api.Data;

/// <summary>
/// A connection type
/// </summary>
[DataContract]
[JsonConverter(typeof(StringEnumConverter))]
public enum ConnectionType
{
	[EnumMember(Value = "Wireless")]
	Wireless = 1,

	[EnumMember(Value = "Wired")]
	Wired
}