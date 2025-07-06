namespace Meraki.Api.Data;

/// <summary>
/// Authority Status
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum AuthorityStatus
{
	/// <summary>
	/// Generating
	/// </summary>
	[EnumMember(Value = "generating")]
	Generating,

	/// <summary>
	/// Trusted
	/// </summary>
	[EnumMember(Value = "trusted")]
	Trusted,

	/// <summary>
	/// Untrusted
	/// </summary>
	[EnumMember(Value = "untrusted")]
	Untrusted
}