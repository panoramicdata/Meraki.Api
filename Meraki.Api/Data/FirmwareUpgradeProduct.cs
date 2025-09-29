﻿namespace Meraki.Api.Data;

/// <summary>
/// Switch
/// </summary>
[DataContract]
public class FirmwareUpgradeProduct
{
	/// <summary>
	/// Whether or not an upgraded firmware version is available
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "isUpgradeAvailable")]
	public bool IsUpgradeAvailable { get; set; }

	/// <summary>
	/// Current version
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "currentVersion")]
	public Version CurrentVersion { get; set; } = new();

	/// <summary>
	/// Last upgrade
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "lastUpgrade")]
	public LastUpgrade LastUpgrade { get; set; } = new();

	/// <summary>
	/// Next upgrade
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "nextUpgrade")]
	public NextUpgrade NextUpgrade { get; set; } = new();

	/// <summary>
	/// Available versions
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "availableVersions")]
	public List<Version> AvailableVersions { get; set; } = [];

	/// <summary>
	/// Participate in next beta release?
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "participateInNextBetaRelease")]
	public bool ParticipateInNextBetaRelease { get; set; }
}
