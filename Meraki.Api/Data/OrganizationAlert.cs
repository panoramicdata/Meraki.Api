using System;
using System.Collections.Generic;
using System.Text;

namespace Meraki.Api.Data;

[DataContract]
public class OrganizationAlert
{
	/// <summary>
	/// Id
	/// </summary>
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// The alert type
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "type")]
	public string Type { get; set; } = string.Empty;

	/// <summary>
	/// Enabled
	/// </summary>
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }

	/// <summary>
	/// The conditions that determine if the alert triggers
	/// </summary>
	[DataMember(Name = "alertCondition")]
	public OrganizationAlertCondition AlertCondition { get; set; } = new();

	/// <summary>
	/// Recipients
	/// </summary>
	[DataMember(Name = "recipients")]
	public OrganizationAlertRecipients Recipients { get; set; } = new();

	/// <summary>
	/// Networks with these tags will be monitored for the alert
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "networkTags")]
	public List<string> NetworkTags { get; set; } = new();

	/// <summary>
	/// User supplied description of the alert
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "description")]
	public string Description { get; set; } = string.Empty;
}
