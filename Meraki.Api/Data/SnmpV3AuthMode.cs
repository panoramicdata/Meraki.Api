using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// The SNMP version 3 authentication mode. Can be either 'MD5' or 'SHA'.
	/// </summary>
	/// <value>The SNMP version 3 authentication mode. Can be either 'MD5' or 'SHA'.</value>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SnmpV3AuthMode
	{
		/// <summary>
		/// Enum MD5 for "MD5"
		/// </summary>
		[EnumMember(Value = "MD5")]
		Md5,

		/// <summary>
		/// Enum SHA for "SHA"
		/// </summary>
		[EnumMember(Value = "SHA")]
		Sha
	}
}
