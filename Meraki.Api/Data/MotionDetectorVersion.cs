using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// The version of the motion detector that will be used by the camera. Only applies to Gen 2 cameras. Defaults to v2.
	/// </summary>
	/// <value>The version of the motion detector that will be used by the camera. Only applies to Gen 2 cameras. Defaults to v2.</value>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum MotionDetectorVersion
	{
		/// <summary>
		/// Enum NUMBER_1 for 1
		/// </summary>
		[EnumMember(Value = "1")]
		V1,

		/// <summary>
		/// Enum NUMBER_2 for 2
		/// </summary>
		[EnumMember(Value = "2")]
		V2
	}
}