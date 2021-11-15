using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;

namespace Meraki.Api.Data;

[JsonConverter(typeof(StringEnumConverter))]
public enum TrafficFilterType
{
	/// <summary>
	/// Enum ApplicationCategory for "applicationCategory"
	/// </summary>
	[EnumMember(Value = "applicationCategory")]
	ApplicationCategory = 1,

	/// <summary>
	/// Enum Application for "application"
	/// </summary>
	[EnumMember(Value = "application")]
	Application,

	/// <summary>
	/// Enum Custom for "custom"
	/// </summary>
	[EnumMember(Value = "custom")]
	Custom,
}
