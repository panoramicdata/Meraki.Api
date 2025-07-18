﻿namespace Meraki.Api.Data;

/// <summary>
/// Organization Inventory Swap Response
/// </summary>
[DataContract]
public class OrganizationInventorySwapResponse
{
	/// <summary>
	/// The ID of the job that was used to create all of the device swaps.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "jobId")]
	public string JobId { get; set; } = string.Empty;

	/// <summary>
	/// An array of recent swap requests and their statuses.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "swaps")]
	public List<OrganizationInventorySwapResponseSwap> Swaps { get; set; } = [];
}
