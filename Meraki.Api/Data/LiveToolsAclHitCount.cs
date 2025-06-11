namespace Meraki.Api.Data;

/// <summary>
/// Live Tools ACL Hit Count
/// </summary>
[DataContract]
public class LiveToolsAclHitCount
{
	/// <summary>
	/// Id of the ACL hit count request. Used to check the status of the request.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "aclHitCountId")]
	public string AclHitCountId { get; set; } = string.Empty;

	/// <summary>
	/// Status of the ACL hit count request.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;

	/// <summary>
	/// GET this url to check the status of your ACL hit count request.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "url")]
	public string Url { get; set; } = string.Empty;

	/// <summary>
	/// Information for callback used to send back results
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "callback")]
	public LiveToolsAclHitCountCallback Callback { get; set; } = new();

	/// <summary>
	/// ACL hit count request parameters
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "request")]
	public LiveToolsAclHitCountRequest Request { get; set; } = new();
}
