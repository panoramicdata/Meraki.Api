using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Choice between 'dual', '2.4ghz' or '5ghz'. Defaults to dual.
	/// </summary>
	/// <value>Choice between 'dual', '2.4ghz' or '5ghz'. Defaults to dual.</value>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum BandOperationMode
	{

		/// <summary>
		/// Enum Dual for "dual"
		/// </summary>
		[EnumMember(Value = "dual")]
		Dual,

		/// <summary>
		/// Enum _24ghz for "2.4ghz"
		/// </summary>
		[EnumMember(Value = "2.4ghz")]
		TwoPointFourGHz,

		/// <summary>
		/// Enum _5ghz for "5ghz"
		/// </summary>
		[EnumMember(Value = "5ghz")]
		FiveGHz
	}
}
