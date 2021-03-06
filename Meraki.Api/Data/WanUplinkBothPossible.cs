using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// The physical WAN interface on which the traffic will arrive ('internet1' or, if available, 'internet2' or 'both')
	/// </summary>
	/// <value>The physical WAN interface on which the traffic will arrive ('internet1' or, if available, 'internet2' or 'both')</value>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum WanUplinkBothPossible
	{
		/// <summary>
		/// Enum Internet1 for "internet1"
		/// </summary>
		[EnumMember(Value = "internet1")]
		Internet1,

		/// <summary>
		/// Enum Internet2 for "internet2"
		/// </summary>
		[EnumMember(Value = "internet2")]
		Internet2,

		/// <summary>
		/// Enum Both for "both"
		/// </summary>
		[EnumMember(Value = "both")]
		Both
	}
}
