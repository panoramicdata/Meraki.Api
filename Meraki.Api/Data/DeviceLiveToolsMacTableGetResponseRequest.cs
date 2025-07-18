﻿namespace Meraki.Api.Data;

/// <summary>
/// MAC table request parameters
/// </summary>
[DataContract]
public class DeviceLiveToolsMacTableGetResponseRequest
{
	/// <summary>
	/// Device serial number
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;
}