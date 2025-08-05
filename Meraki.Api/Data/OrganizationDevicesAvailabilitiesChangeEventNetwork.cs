﻿namespace Meraki.Api.Data;

/// <summary>
/// Network information
/// </summary>
[DataContract]
[DebuggerDisplay("{Name} ({Id})")]
public class OrganizationDevicesAvailabilitiesChangeEventNetwork
{
	/// <summary>
	/// Network id
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// Network name
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Network dashboard url
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "url")]
	public string Url { get; set; } = string.Empty;

	/// <summary>
	/// Network tags
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "tags")]
	public List<string> Tags { get; set; } = [];
}