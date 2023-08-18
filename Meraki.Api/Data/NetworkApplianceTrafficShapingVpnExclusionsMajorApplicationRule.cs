namespace Meraki.Api.Data;

/// <summary>
/// NetworkApplianceTrafficShapingVpnExclusionsMajorApplicationRule
/// </summary>
[DataContract]
public class NetworkApplianceTrafficShapingVpnExclusionsMajorApplicationRule
{
	/// <summary>
	/// Application's Meraki ID.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// Application's name. Valid values are 'AWS', 'Box', 'Office 365 Sharepoint', 'Office 365 Suite', 'Oracle', 'SAP', 'Salesforce', 'Skype & Teams', 'Slack', 'Webex', 'Webex Calling', 'Webex Meetings', 'Zoom'
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;
}
