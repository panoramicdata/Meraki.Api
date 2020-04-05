using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// The 'SM Forums' subtab which links to community-based support for Cisco Meraki Systems Manager. Only configurable for     organizations that contain Systems Manager networks. Can be one of 'default or inherit', 'hide' or 'show'.
	/// </summary>
	/// <value>The 'SM Forums' subtab which links to community-based support for Cisco Meraki Systems Manager. Only configurable for     organizations that contain Systems Manager networks. Can be one of 'default or inherit', 'hide' or 'show'.</value>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SmForum
	{

		/// <summary>
		/// Enum Defaultorinherit for "default or inherit"
		/// </summary>
		[EnumMember(Value = "default or inherit")]
		Defaultorinherit,

		/// <summary>
		/// Enum Hide for "hide"
		/// </summary>
		[EnumMember(Value = "hide")]
		Hide,

		/// <summary>
		/// Enum Show for "show"
		/// </summary>
		[EnumMember(Value = "show")]
		Show
	}
}
