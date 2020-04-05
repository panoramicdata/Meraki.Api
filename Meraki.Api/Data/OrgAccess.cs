using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Meraki.Api.Data
{
	/// <summary>
	/// The privilege of the dashboard administrator on the organization. Can be one of 'full', 'read-only', 'enterprise' or 'none'
	/// </summary>
	/// <value>The privilege of the dashboard administrator on the organization. Can be one of 'full', 'read-only', 'enterprise' or 'none'</value>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum OrgAccess
	{

		/// <summary>
		/// Enum Full for "full"
		/// </summary>
		[EnumMember(Value = "full")]
		Full,

		/// <summary>
		/// Enum Readonly for "read-only"
		/// </summary>
		[EnumMember(Value = "read-only")]
		Readonly,

		/// <summary>
		/// Enum Enterprise for "enterprise"
		/// </summary>
		[EnumMember(Value = "enterprise")]
		Enterprise,

		/// <summary>
		/// Enum None for "none"
		/// </summary>
		[EnumMember(Value = "none")]
		None
	}
}
