using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// The association control method for the SSID ('open', 'psk', 'open-with-radius', '8021x-meraki', '8021x-radius', 'ipsk-with-radius' or 'ipsk-without-radius')
	/// </summary>
	/// <value>The association control method for the SSID ('open', 'psk', 'open-with-radius', '8021x-meraki', '8021x-radius', 'ipsk-with-radius' or 'ipsk-without-radius')</value>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum AuthMode
	{
		/// <summary>
		/// Enum Open for "open"
		/// </summary>
		[EnumMember(Value = "open")]
		Open,

		/// <summary>
		/// Enum Psk for "psk"
		/// </summary>
		[EnumMember(Value = "psk")]
		Psk,

		/// <summary>
		/// Enum Openwithradius for "open-with-radius"
		/// </summary>
		[EnumMember(Value = "open-with-radius")]
		Openwithradius,

		/// <summary>
		/// Enum _8021xmeraki for "8021x-meraki"
		/// </summary>
		[EnumMember(Value = "8021x-meraki")]
		_8021xmeraki,

		/// <summary>
		/// Enum _8021xradius for "8021x-radius"
		/// </summary>
		[EnumMember(Value = "8021x-radius")]
		_8021xradius,

		/// <summary>
		/// Enum Ipskwithradius for "ipsk-with-radius"
		/// </summary>
		[EnumMember(Value = "ipsk-with-radius")]
		Ipskwithradius,

		/// <summary>
		/// Enum Ipskwithoutradius for "ipsk-without-radius"
		/// </summary>
		[EnumMember(Value = "ipsk-without-radius")]
		Ipskwithoutradius
	}
}
