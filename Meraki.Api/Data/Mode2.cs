using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Meraki.Api.Data
{
	/// <summary>
	/// The site-to-site VPN mode. Can be one of 'none', 'spoke' or 'hub'
	/// </summary>
	/// <value>The site-to-site VPN mode. Can be one of 'none', 'spoke' or 'hub'</value>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum Mode2
	{

		/// <summary>
		/// Enum None for "none"
		/// </summary>
		[EnumMember(Value = "none")]
		None,

		/// <summary>
		/// Enum Spoke for "spoke"
		/// </summary>
		[EnumMember(Value = "spoke")]
		Spoke,

		/// <summary>
		/// Enum Hub for "hub"
		/// </summary>
		[EnumMember(Value = "hub")]
		Hub
	}
}
