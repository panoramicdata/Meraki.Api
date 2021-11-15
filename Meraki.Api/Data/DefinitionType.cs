using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// The type of definition. Can be one of 'application', 'applicationCategory', 'host', 'port', 'ipRange' or 'localNet'.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum DefinitionType
{
	/// <summary>
	/// Enum Application for "application"
	/// </summary>
	[EnumMember(Value = "application")]
	Application,

	/// <summary>
	/// Enum ApplicationCategory for "applicationCategory"
	/// </summary>
	[EnumMember(Value = "applicationCategory")]
	ApplicationCategory,

	/// <summary>
	/// Enum Host for "host"
	/// </summary>
	[EnumMember(Value = "host")]
	Host,

	/// <summary>
	/// Enum Port for "port"
	/// </summary>
	[EnumMember(Value = "port")]
	Port,

	/// <summary>
	/// Enum IpRange for "ipRange"
	/// </summary>
	[EnumMember(Value = "ipRange")]
	IpRange,

	/// <summary>
	/// Enum LocalNet for "localNet"
	/// </summary>
	[EnumMember(Value = "localNet")]
	LocalNet
}
