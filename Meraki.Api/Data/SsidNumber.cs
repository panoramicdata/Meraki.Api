using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Defines ssidNumber
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SsidNumber
	{

		/// <summary>
		/// Enum Number0 for 0
		/// </summary>
		[EnumMember(Value = "0")]
		Number0,

		/// <summary>
		/// Enum Number1 for 1
		/// </summary>
		[EnumMember(Value = "1")]
		Number1,

		/// <summary>
		/// Enum Number2 for 2
		/// </summary>
		[EnumMember(Value = "2")]
		Number2,

		/// <summary>
		/// Enum Number3 for 3
		/// </summary>
		[EnumMember(Value = "3")]
		Number3,

		/// <summary>
		/// Enum Number4 for 4
		/// </summary>
		[EnumMember(Value = "4")]
		Number4,

		/// <summary>
		/// Enum Number5 for 5
		/// </summary>
		[EnumMember(Value = "5")]
		Number5,

		/// <summary>
		/// Enum Number6 for 6
		/// </summary>
		[EnumMember(Value = "6")]
		Number6,

		/// <summary>
		/// Enum Number7 for 7
		/// </summary>
		[EnumMember(Value = "7")]
		Number7,

		/// <summary>
		/// Enum Number8 for 8
		/// </summary>
		[EnumMember(Value = "8")]
		Number8,

		/// <summary>
		/// Enum Number9 for 9
		/// </summary>
		[EnumMember(Value = "9")]
		Number9,

		/// <summary>
		/// Enum Number10 for 10
		/// </summary>
		[EnumMember(Value = "10")]
		Number10,

		/// <summary>
		/// Enum Number11 for 11
		/// </summary>
		[EnumMember(Value = "11")]
		Number11,

		/// <summary>
		/// Enum Number12 for 12
		/// </summary>
		[EnumMember(Value = "12")]
		Number12,

		/// <summary>
		/// Enum Number13 for 13
		/// </summary>
		[EnumMember(Value = "13")]
		Number13,

		/// <summary>
		/// Enum Number14 for 14
		/// </summary>
		[EnumMember(Value = "14")]
		Number14
	}
}
