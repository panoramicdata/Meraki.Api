namespace Meraki.Api.Data;

/// <summary>
/// Enum for Radius Authentication Mode
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum RadiusAuthenticationMode
{
	/// <summary>
	/// Closed
	/// </summary>
	[EnumMember(Value = "closed")]
	Closed,

	/// <summary>
	/// Opem
	/// </summary>
	[EnumMember(Value = "open")]
	Open
}
