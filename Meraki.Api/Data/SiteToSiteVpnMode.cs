using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// The site-to-site VPN mode. Can be one of 'none', 'spoke' or 'hub'
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SiteToSiteVpnMode
	{
		/// <summary>
		/// Enum None for "none"
		/// </summary>
		[EnumMember(Value = "none")]
		None = 1,

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
