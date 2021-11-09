using Meraki.Api.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Area types in OSPF. Must be one of: ["normal", "stub", "nssa"]
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum AreaType
	{
		/// <summary>
		/// Enum Normal for "normal"
		/// </summary>
		[EnumMember(Value = "normal")]
		Normal = 1,

		/// <summary>
		/// Enum Stub for "stub"
		/// </summary>
		[EnumMember(Value = "stub")]
		Stub,

		/// <summary>
		/// Enum Nssa for "nssa"
		/// </summary>
		[EnumMember(Value = "nssa")]
		Nssa
	}
}