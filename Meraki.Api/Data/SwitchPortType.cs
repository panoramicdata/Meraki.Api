using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// The type of the switch port ('trunk' or 'access')
	/// </summary>
	/// <value>The type of the switch port ('trunk' or 'access')</value>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SwitchPortType
	{

		/// <summary>
		/// Enum Trunk for "trunk"
		/// </summary>
		[EnumMember(Value = "trunk")]
		Trunk,

		/// <summary>
		/// Enum Access for "access"
		/// </summary>
		[EnumMember(Value = "access")]
		Access
	}
}
