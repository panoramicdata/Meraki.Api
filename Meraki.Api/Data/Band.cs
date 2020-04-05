using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Defines band
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum Band
	{

		/// <summary>
		/// Enum Band2Point4GHz for "2.4"
		/// </summary>
		[EnumMember(Value = "2.4")]
		TwoPointFourGHz,

		/// <summary>
		/// Enum Band5GHz for "5"
		/// </summary>
		[EnumMember(Value = "5")]
		FiveGHz
	}
}
