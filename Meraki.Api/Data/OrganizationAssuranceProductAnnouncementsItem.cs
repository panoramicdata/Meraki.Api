namespace Meraki.Api.Data;

/// <summary>
/// Announcement
/// </summary>
[DataContract]
public class OrganizationAssuranceProductAnnouncementsItem
{
	/// <summary>
	/// The unique identifier of the board
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "boardId")]
	public string BoardId { get; set; } = string.Empty;

	/// <summary>
	/// The timestamp of when the announcement was edited
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "editedAt")]
	public string EditedAt { get; set; } = string.Empty;

	/// <summary>
	/// The unique identifier of the announcement
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// The timestamp of when the announcement was published
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "publishedAt")]
	public string PublishedAt { get; set; } = string.Empty;

	/// <summary>
	/// The snippet of the announcement
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "snippet")]
	public string Snippet { get; set; } = string.Empty;

	/// <summary>
	/// The title of the announcement
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "title")]
	public string Title { get; set; } = string.Empty;

	/// <summary>
	/// The URL of the announcement
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "url")]
	public string Url { get; set; } = string.Empty;

	/// <summary>
	/// The labels of the announcement
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "labels")]
	public List<OrganizationAssuranceProductAnnouncementsItemLabel> Labels { get; set; } = [];
}
