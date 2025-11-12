namespace Meraki.Api.Data;

/// <summary>
/// Organization Alert Profile
/// </summary>
[DataContract]
public class OrganizationAlertProfile : IdentifiedItem
{
	/// <summary>
	/// The alert type
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "type")]
	public string Type { get; set; } = null!;

	/// <summary>
	/// Enabled
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }

	/// <summary>
	/// The conditions that determine if the alert triggers
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "alertCondition")]
	public OrganizationAlertCondition AlertCondition { get; set; } = null!;

	/// <summary>
	/// List of recipients that will recieve the alert.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "recipients")]
	public OrganizationAlertRecipients Recipients { get; set; } = null!;

	/// <summary>
	/// Networks with these tags will be monitored for the alert
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "networkTags")]
	public List<string> NetworkTags { get; set; } = null!;

	/// <summary>
	/// User supplied description of the alert
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "description")]
	public string? Description { get; set; }
}
