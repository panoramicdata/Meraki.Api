using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Defines state
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum State
	{

		/// <summary>
		/// Enum Active for "active"
		/// </summary>
		[EnumMember(Value = "active")]
		Active,

		/// <summary>
		/// Enum Expired for "expired"
		/// </summary>
		[EnumMember(Value = "expired")]
		Expired,

		/// <summary>
		/// Enum Expiring for "expiring"
		/// </summary>
		[EnumMember(Value = "expiring")]
		Expiring,

		/// <summary>
		/// Enum Unused for "unused"
		/// </summary>
		[EnumMember(Value = "unused")]
		Unused,

		/// <summary>
		/// Enum UnusedActive for "unusedActive"
		/// </summary>
		[EnumMember(Value = "unusedActive")]
		UnusedActive,

		/// <summary>
		/// Enum RecentlyQueued for "recentlyQueued"
		/// </summary>
		[EnumMember(Value = "recentlyQueued")]
		RecentlyQueued
	}
}
