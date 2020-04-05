using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Resolution of the camera. Can be one of '1280x720', '1920x1080', '1080x1080' or '2058x2058'. Not all resolutions are supported by every camera model.
	/// </summary>
	/// <value>Resolution of the camera. Can be one of '1280x720', '1920x1080', '1080x1080' or '2058x2058'. Not all resolutions are supported by every camera model.</value>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum Resolution
	{

		/// <summary>
		/// Enum _1280x720 for "1280x720"
		/// </summary>
		[EnumMember(Value = "1280x720")]
		Size1280x720,

		/// <summary>
		/// Enum _1920x1080 for "1920x1080"
		/// </summary>
		[EnumMember(Value = "1920x1080")]
		Size1920x1080,

		/// <summary>
		/// Enum _1080x1080 for "1080x1080"
		/// </summary>
		[EnumMember(Value = "1080x1080")]
		Size1080x1080,

		/// <summary>
		/// Enum _2058x2058 for "2058x2058"
		/// </summary>
		[EnumMember(Value = "2058x2058")]
		Size2058x2058
	}
}
