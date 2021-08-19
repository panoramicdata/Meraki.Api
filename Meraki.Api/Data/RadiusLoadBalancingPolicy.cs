using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// This policy determines which RADIUS server will be contacted first in an authentication attempt and the ordering of any necessary retry attempts ('Strict priority order' or 'Round robin')
	/// </summary>
	/// <value>This policy determines which RADIUS server will be contacted first in an authentication attempt and the ordering of any necessary retry attempts ('Strict priority order' or 'Round robin')</value>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum RadiusLoadBalancingPolicy
	{
		/// <summary>
		/// Enum Strictpriorityorder for "Strict priority order"
		/// </summary>
		[EnumMember(Value = "Strict priority order")]
		Strictpriorityorder,

		/// <summary>
		/// Enum Roundrobin for "Round robin"
		/// </summary>
		[EnumMember(Value = "Round robin")]
		Roundrobin
	}
}
