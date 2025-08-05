namespace Meraki.Api.Data;

/// <summary>
/// Organizations Cloud Enrollment Sync Job
/// </summary>
[DataContract]
public class OrganizationsCloudEnrollmentSyncJob
{
	/// <summary>
	/// The id of the ADE account
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "adeAccountId")]
	public string AdeAccountId { get; set; } = string.Empty;

	/// <summary>
	/// The status of the ADE Sync Job
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;

	/// <summary>
	/// The id of the ADE Sync Job
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "syncJobId")]
	public string SyncJobId { get; set; } = string.Empty;
}
