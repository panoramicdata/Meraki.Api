using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Meraki.Api.Data
{
	/// <summary>
	/// One of \"delete\" or \"restrict processing\"
	/// </summary>
	/// <value>One of \"delete\" or \"restrict processing\"</value>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum Type6
	{

		/// <summary>
		/// Enum Delete for "delete"
		/// </summary>
		[EnumMember(Value = "delete")]
		Delete,

		/// <summary>
		/// Enum Restrictprocessing for "restrict processing"
		/// </summary>
		[EnumMember(Value = "restrict processing")]
		Restrictprocessing
	}
}
