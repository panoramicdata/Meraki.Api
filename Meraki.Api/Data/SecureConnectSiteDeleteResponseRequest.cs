namespace Meraki.Api.Data;

/// <summary>
/// Request that was sent to the job
/// </summary>
[DataContract]
public class SecureConnectSiteDeleteResponseRequest
{
	/// <summary>
	/// ID of the site to enroll
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "siteId")]
	public string SiteId { get; set; } = string.Empty;
}