﻿namespace Meraki.Api.Data;

/// <summary>
/// Device Live Tools MAC Table Create Response
/// </summary>
[DataContract]
public class DeviceLiveToolsMacTableCreateResponse
{
	/// <summary>
	/// ID of the MAC table request. Used to check the status of the request.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "macTableId")]
	public string MacTableId { get; set; } = string.Empty;

	/// <summary>
	/// Status of the MAC table request. enum = ["complete", "failed", "new", "ready", "running", ...]
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;

	/// <summary>
	/// GET this url to check the status of your MAC table request.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "url")]
	public string Url { get; set; } = string.Empty;

	/// <summary>
	/// Information for callback used to send back results
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "callback")]
	public DeviceLiveToolsMacTableCreateResponseCallback Callback { get; set; } = new();

	/// <summary>
	/// MAC table request parameters
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "request")]
	public DeviceLiveToolsMacTableCreateResponseRequest Request { get; set; } = new();
}
