using Meraki.Api.Attributes;
using System;
using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// A change log entry
/// </summary>
[DataContract]
public class ChangeLogEntry
{
	/// <summary>
	/// The Timestamp
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ts")]
	public DateTime TimeStamp { get; set; }

	/// <summary>
	/// The admin name
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "adminName")]
	public string AdminName { get; set; } = string.Empty;

	/// <summary>
	/// The admin email address
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "adminEmail")]
	public string AdminEmail { get; set; } = string.Empty;

	/// <summary>
	/// The admin id
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "adminId")]
	public string AdminId { get; set; } = string.Empty;

	/// <summary>
	/// The page
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "page")]
	public string Page { get; set; } = string.Empty;

	/// <summary>
	/// The label
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "label")]
	public string Label { get; set; } = string.Empty;

	/// <summary>
	/// The old value
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "oldValue")]
	public string OldValue { get; set; } = string.Empty;

	/// <summary>
	/// The new value
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "newValue")]
	public string NewValue { get; set; } = string.Empty;

	/// <summary>
	/// The Name of the Network
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "networkName")]
	public string? NetworkName { get; set; }

	/// <summary>
	/// The Name of the Network
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "networkId")]
	public string? NetworkId { get; set; }

	public override string ToString() => Label;
}
