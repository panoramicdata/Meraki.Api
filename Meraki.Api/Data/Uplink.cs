using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// Defines uplink
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum Uplink
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
}
