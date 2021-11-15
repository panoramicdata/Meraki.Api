using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// Whether clients bound to your policy will bypass splash authorization or behave according to the network's rules. Can be one of 'network default' or 'bypass'. Only available if your network has a wireless configuration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum SplashAuthSetting
{
	/// <summary>
	/// Enum Networkdefault for "network default"
	/// </summary>
	[EnumMember(Value = "network default")]
	Networkdefault,

	/// <summary>
	/// Enum Bypass for "bypass"
	/// </summary>
	[EnumMember(Value = "bypass")]
	Bypass
}
