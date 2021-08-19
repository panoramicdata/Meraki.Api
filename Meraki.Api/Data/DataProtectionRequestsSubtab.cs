using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// The 'Help -> Data protection requests' Dashboard subtab on which requests to delete, restrict, or export end-user data can     be audited. Can be one of 'default or inherit', 'hide' or 'show'.
	/// </summary>
	/// <value>The 'Help -> Data protection requests' Dashboard subtab on which requests to delete, restrict, or export end-user data can     be audited. Can be one of 'default or inherit', 'hide' or 'show'.</value>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum DataProtectionRequestsSubtab
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
