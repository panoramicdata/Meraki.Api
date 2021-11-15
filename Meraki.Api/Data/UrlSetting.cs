using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// How URL patterns are applied. Can be 'network default', 'append' or 'override'.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum UrlSetting
{
	/// <summary>
	/// Enum Networkdefault for "network default"
	/// </summary>
	[EnumMember(Value = "network default")]
	Networkdefault,

	/// <summary>
	/// Enum Append for "append"
	/// </summary>
	[EnumMember(Value = "append")]
	Append,

	/// <summary>
	/// Enum Override for "override"
	/// </summary>
	[EnumMember(Value = "override")]
	Override
}
