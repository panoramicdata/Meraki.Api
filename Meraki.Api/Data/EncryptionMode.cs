using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Meraki.Api.Data
{
	/// <summary>
	/// The psk encryption mode for the SSID ('wep' or 'wpa'). This param is only valid if the authMode is 'psk'
	/// </summary>
	/// <value>The psk encryption mode for the SSID ('wep' or 'wpa'). This param is only valid if the authMode is 'psk'</value>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum EncryptionMode
	{

		/// <summary>
		/// Enum Wep for "wep"
		/// </summary>
		[EnumMember(Value = "wep")]
		Wep,

		/// <summary>
		/// Enum Wpa for "wpa"
		/// </summary>
		[EnumMember(Value = "wpa")]
		Wpa
	}
}
