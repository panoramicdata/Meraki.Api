﻿namespace Meraki.Api.Data;

/// <summary>
///A Schedule Assigned to a Port
/// </summary>
[DataContract]
public class SwitchPortAssignedSchedule
{
	/// <summary>
	/// ID of the assigned schedule
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// Name of the assigned schedule
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;
}
