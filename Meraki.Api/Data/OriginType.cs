namespace Meraki.Api.Data;

/// <summary>
/// Origin Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum OriginType
{
	/// <summary>
	/// Independent
	/// </summary>
	[EnumMember(Value = "independent")]
	Independent,

	/// <summary>
	/// Internet
	/// </summary>
	[EnumMember(Value = "internet")]
	Internet
}