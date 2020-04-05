using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Defines objectType
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ObjectType
	{

		/// <summary>
		/// Enum Person for "person"
		/// </summary>
		[EnumMember(Value = "person")]
		Person,

		/// <summary>
		/// Enum Vehicle for "vehicle"
		/// </summary>
		[EnumMember(Value = "vehicle")]
		Vehicle
	}
}
