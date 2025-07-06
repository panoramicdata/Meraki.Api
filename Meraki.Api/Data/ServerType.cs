namespace Meraki.Api.Data;

/// <summary>
/// Type of server
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum ServerType
{
	/// <summary>
	/// Accounting
	/// </summary>
	[EnumMember(Value = "accounting")]
	Accounting,

	/// <summary>
	/// Auth
	/// </summary>
	[EnumMember(Value = "auth")]
	Auth
}