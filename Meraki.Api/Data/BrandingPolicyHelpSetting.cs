using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum BrandingPolicyHelpSetting
	{
		/// <summary>
		/// Enum Defaultorinherit for "default or inherit"
		/// </summary>
		[EnumMember(Value = "default or inherit")]
		DefaultOrInherit = 1,

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
