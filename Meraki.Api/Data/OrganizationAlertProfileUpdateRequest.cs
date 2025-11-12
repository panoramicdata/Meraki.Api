namespace Meraki.Api.Data;

/// <summary>
/// Organization Alert Profile Update
/// </summary>
[DataContract]
public class OrganizationAlertProfileUpdateRequest
{
	/// <summary>
	/// The alert type
	/// </summary>
	[DataMember(Name = "type")]
	public string? Type { get; set; }

	/// <summary>
	/// Enabled
	/// </summary>
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }

	/// <summary>
	/// The conditions that determine if the alert triggers
	/// </summary>
	[DataMember(Name = "alertCondition")]
	public OrganizationAlertCondition? AlertCondition { get; set; }

	/// <summary>
	/// List of recipients that will recieve the alert.
	/// </summary>
	[DataMember(Name = "recipients")]
	public OrganizationAlertRecipients? Recipients { get; set; }

	/// <summary>
	/// Networks with these tags will be monitored for the alert
	/// </summary>
	[DataMember(Name = "networkTags")]
	public List<string>? NetworkTags { get; set; }

	/// <summary>
	/// User supplied description of the alert
	/// </summary>
	[DataMember(Name = "description")]
	public string? Description { get; set; }
}
