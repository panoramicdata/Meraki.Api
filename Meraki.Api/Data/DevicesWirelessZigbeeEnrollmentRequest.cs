﻿namespace Meraki.Api.Data;

/// <summary>
/// Enrollment request parameters
/// </summary>
[DataContract]
public class DevicesWirelessZigbeeEnrollmentRequest
{
	/// <summary>
	/// Device serial number
	/// </summary>
	[DataMember(Name = "serial")]
	[ApiAccess(ApiAccess.Read)]
	public string? Serial { get; set; }
}