namespace Meraki.Api.Data;

/// <summary>
/// The term of DHCP leases if the appliance is running a DHCP server on this VLAN. One of: '30 minutes', '1 hour', '4 hours', '12 hours', '1 day' or '1 week'
/// </summary>
/// <value>The term of DHCP leases if the appliance is running a DHCP server on this VLAN. One of: '30 minutes', '1 hour', '4 hours', '12 hours', '1 day' or '1 week'</value>
[JsonConverter(typeof(StringEnumConverter))]
public enum DhcpLeaseTime
{
	/// <summary>
	/// Enum _30minutes for "30 minutes"
	/// </summary>
	[EnumMember(Value = "30 minutes")]
	_30minutes,

	/// <summary>
	/// Enum _1hour for "1 hour"
	/// </summary>
	[EnumMember(Value = "1 hour")]
	_1hour,

	/// <summary>
	/// Enum _4hours for "4 hours"
	/// </summary>
	[EnumMember(Value = "4 hours")]
	_4hours,

	/// <summary>
	/// Enum _12hours for "12 hours"
	/// </summary>
	[EnumMember(Value = "12 hours")]
	_12hours,

	/// <summary>
	/// Enum _1day for "1 day"
	/// </summary>
	[EnumMember(Value = "1 day")]
	_1day,

	/// <summary>
	/// Enum _1week for "1 week"
	/// </summary>
	[EnumMember(Value = "1 week")]
	_1week
}
