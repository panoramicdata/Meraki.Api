namespace Meraki.Api.Data;

/// <summary>
/// Label for an announcement item
/// </summary>
[DataContract]
public class OrganizationAssuranceProductAnnouncementsItemLabel
{
	/// <summary>
	/// The unique identifier of the label
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// The name of the label
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;
}