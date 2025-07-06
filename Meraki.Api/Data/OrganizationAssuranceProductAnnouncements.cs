namespace Meraki.Api.Data;

/// <summary>
/// Organization Assurance Product Announcements
/// </summary>
[DataContract]
public class OrganizationAssuranceProductAnnouncements
{
	/// <summary>
	/// The metadata for the returned datasets
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "meta")]
	public OrganizationAssuranceProductAnnouncementsMetadata Meta { get; set; } = new();

	/// <summary>
	/// The list of announcements
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "items")]
	public List<OrganizationAssuranceProductAnnouncementsItem> Items { get; set; } = [];
}
