using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// A string indicating the rule for which IPs are allowed to use the specified service. Acceptable values are \"blocked\" (no remote IPs can access the service), \"restricted\" (only whitelisted IPs can access the service), and \"unrestriced\" (any remote IP can access the service). This field is required
	/// </summary>
	/// <value>A string indicating the rule for which IPs are allowed to use the specified service. Acceptable values are \"blocked\" (no remote IPs can access the service), \"restricted\" (only whitelisted IPs can access the service), and \"unrestriced\" (any remote IP can access the service). This field is required</value>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum Access
	{
		/// <summary>
		/// Enum Blocked for "blocked"
		/// </summary>
		[EnumMember(Value = "blocked")]
		Blocked,

		/// <summary>
		/// Enum Restricted for "restricted"
		/// </summary>
		[EnumMember(Value = "restricted")]
		Restricted,

		/// <summary>
		/// Enum Unrestricted for "unrestricted"
		/// </summary>
		[EnumMember(Value = "unrestricted")]
		Unrestricted
	}
}