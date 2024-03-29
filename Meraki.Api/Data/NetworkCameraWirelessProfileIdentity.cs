﻿namespace Meraki.Api.Data;

/// <summary>
/// The identity of the wireless profile. Required for creating wireless profiles in 8021x-radius auth mode.
/// </summary>
[DataContract]
public class NetworkCameraWirelessProfileIdentity
{
	/// <summary>
	/// The password of the identity.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "password")]
	public string Password { get; set; } = string.Empty;

	/// <summary>
	/// The username of the identity.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "username")]
	public string Username { get; set; } = string.Empty;
}
