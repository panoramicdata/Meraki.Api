using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Meraki.Api.Data
{
	/// <summary>
	/// The 'Help -> Replacement info' subtab where important information regarding device replacements is detailed. Can be one of     'default or inherit', 'hide' or 'show'.
	/// </summary>
	/// <value>The 'Help -> Replacement info' subtab where important information regarding device replacements is detailed. Can be one of     'default or inherit', 'hide' or 'show'.</value>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum HardwareReplacementsSubtab
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
