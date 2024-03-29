﻿namespace Meraki.Api.Data;

/// <summary>
/// Network wireless profiles
/// </summary>
[DataContract]
public class NetworkCameraWirelessProfile : NetworkCameraWirelessProfileCreateUpdateRequest
{
	/// <summary>
	/// Id
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// Applied device count
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "appliedDeviceCount")]
	public int AppliedDeviceCount { get; set; }
}
