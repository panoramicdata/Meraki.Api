﻿namespace Meraki.Api.Data;

/// <summary>
/// OSPF neighbors request parameters
/// </summary>
[DataContract]
public class DeviceLiveToolsOspfNeighborCreateResponseRequest
{
	/// <summary>
	/// Device serial number
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;
}