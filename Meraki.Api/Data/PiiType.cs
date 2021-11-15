using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// One of "delete" or "restrict processing"
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum PiiType
{
	/// <summary>
	/// Enum Delete for "delete"
	/// </summary>
	[EnumMember(Value = "delete")]
	Delete,

	/// <summary>
	/// Enum Restrictprocessing for "restrict processing"
	/// </summary>
	[EnumMember(Value = "restrict processing")]
	Restrictprocessing
}
