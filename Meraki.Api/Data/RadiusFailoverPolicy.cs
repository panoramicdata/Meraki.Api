using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// This policy determines how authentication requests should be handled in the event that all of the configured RADIUS servers are unreachable ('Deny access' or 'Allow access')
	/// </summary>
	/// <value>This policy determines how authentication requests should be handled in the event that all of the configured RADIUS servers are unreachable ('Deny access' or 'Allow access')</value>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum RadiusFailoverPolicy
	{
		/// <summary>
		/// Enum Denyaccess for "Deny access"
		/// </summary>
		[EnumMember(Value = "Deny access")]
		Denyaccess,

		/// <summary>
		/// Enum Allowaccess for "Allow access"
		/// </summary>
		[EnumMember(Value = "Allow access")]
		Allowaccess
	}
}
