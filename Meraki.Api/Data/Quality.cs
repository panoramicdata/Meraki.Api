using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Quality of the camera. Can be one of 'Standard', 'High' or 'Enhanced'. Not all qualities are supported by every camera model.
	/// </summary>
	/// <value>Quality of the camera. Can be one of 'Standard', 'High' or 'Enhanced'. Not all qualities are supported by every camera model.</value>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum Quality
	{

		/// <summary>
		/// Enum Standard for "Standard"
		/// </summary>
		[EnumMember(Value = "Standard")]
		Standard,

		/// <summary>
		/// Enum High for "High"
		/// </summary>
		[EnumMember(Value = "High")]
		High,

		/// <summary>
		/// Enum Enhanced for "Enhanced"
		/// </summary>
		[EnumMember(Value = "Enhanced")]
		Enhanced
	}
}
