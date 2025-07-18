﻿namespace Meraki.Api.Data;

/// <summary>
/// Network of device
/// </summary>
[DataContract]
public class OrganizationsWirelessRadioAfcByDeviceNetwork
{
	/// <summary>
	/// Network ID
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;
}