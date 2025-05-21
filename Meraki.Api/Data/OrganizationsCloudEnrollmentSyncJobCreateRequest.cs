namespace Meraki.Api.Data;

/// <summary>
/// Organizations Cloud Enrollment Sync Job Create Request
/// </summary>
[DataContract]
public class OrganizationsCloudEnrollmentSyncJobCreateRequest
{
	/// <summary>
	/// ADE Account ID
	/// </summary>
	[DataMember(Name = "adeAccountId")]
	public string? AdeAccountId { get; set; }

	/// <summary>
	/// Whether or not job is full sync (defaults to full sync) default = false
	/// </summary>
	[DataMember(Name = "fullSync")]
	public bool? FullSync { get; set; }
}
