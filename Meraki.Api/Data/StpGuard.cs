using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// The state of the STP guard ('disabled', 'root guard', 'bpdu guard' or 'loop guard')
/// </summary>
/// <value>The state of the STP guard ('disabled', 'root guard', 'bpdu guard' or 'loop guard')</value>
[JsonConverter(typeof(StringEnumConverter))]
public enum StpGuard
{
	/// <summary>
	/// Enum Disabled for "disabled"
	/// </summary>
	[EnumMember(Value = "disabled")]
	Disabled = 1,

	/// <summary>
	/// Enum Rootguard for "root guard"
	/// </summary>
	[EnumMember(Value = "root guard")]
	Rootguard,

	/// <summary>
	/// Enum Bpduguard for "bpdu guard"
	/// </summary>
	[EnumMember(Value = "bpdu guard")]
	Bpduguard,

	/// <summary>
	/// Enum Loopguard for "loop guard"
	/// </summary>
	[EnumMember(Value = "loop guard")]
	Loopguard
}
