﻿namespace Meraki.Api.Data;

/// <summary>
/// The Door lock status
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum DevicesWirelessZigbeeDoorLocksStatus
{
	/// <summary>
	/// Offline
	/// </summary>
	[EnumMember(Value = "offline")]
	Offline,

	/// <summary>
	/// Online
	/// </summary>
	[EnumMember(Value = "online")]
	Online
}