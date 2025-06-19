namespace Meraki.Api.Data;

/// <summary>
/// Organization Assurance Alerts Taxonomy Type
/// </summary>
[DataContract]
public class OrganizationAssuranceAlertsTaxonomyType
{
	/// <summary>
	/// Alert category type
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "categoryType")]
	public string CategoryType { get; set; } = string.Empty;

	/// <summary>
	/// Alert type title
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "title")]
	public string Title { get; set; } = string.Empty;

	/// <summary>
	/// Alert type
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "type")]
	public string Type { get; set; } = string.Empty;

	/// <summary>
	/// List of possible device types for the alert type
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "deviceTypes")]
	public List<string> DeviceTypes { get; set; } = [];

	/// <summary>
	/// List of possible severities for the alert type
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "severities")]
	public List<OrganizationAssuranceAlertsTaxonomyTypeSeverity> Severities { get; set; } = [];
}
