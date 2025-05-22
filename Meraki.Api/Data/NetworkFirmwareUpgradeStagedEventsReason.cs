﻿namespace Meraki.Api.Data;

/// <summary>
/// A Reason for the rollback
/// </summary>
[DataContract]
public class NetworkFirmwareUpgradeStagedEventsReason
{
	/// <summary>
	/// Reason for the rollback
	/// </summary>
	[DataMember(Name = "category")]
	[ApiAccess(ApiAccess.ReadWrite)]
	public string? Category { get; set; }

	/// <summary>
	/// Additional comment about the rollback
	/// </summary>
	[DataMember(Name = "comment")]
	[ApiAccess(ApiAccess.ReadWrite)]
	public string? Comment { get; set; }
}
