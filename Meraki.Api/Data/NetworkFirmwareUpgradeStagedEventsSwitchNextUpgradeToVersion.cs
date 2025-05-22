﻿namespace Meraki.Api.Data;

/// <summary>
/// Details of the version the device will upgrade to
/// </summary>
[DataContract]
public class NetworkFirmwareUpgradeStagedEventsSwitchNextUpgradeToVersion
{
	/// <summary>
	/// Id of the Version being upgraded to
	/// </summary>
	[DataMember(Name = "id")]
	[ApiAccess(ApiAccess.Read)]
	public string? Id { get; set; }

	/// <summary>
	/// Firmware version short name
	/// </summary>
	[DataMember(Name = "shortName")]
	[ApiAccess(ApiAccess.Read)]
	public string? ShortName { get; set; }
}