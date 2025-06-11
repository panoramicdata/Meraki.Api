namespace Meraki.Api.Data;

/// <summary>
/// Live Tools ACL Hit Count Get Response
/// </summary>
[DataContract]
public class LiveToolsAclHitCountGetResponse
{
	/// <summary>
	/// Id of the ACL hit count request. Used to check the status of the request.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "aclHitCountId")]
	public string AclHitCountId { get; set; } = string.Empty;

	/// <summary>
	/// An error message for a failed execution
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "error")]
	public string Error { get; set; } = string.Empty;

	/// <summary>
	/// Status of the ACL hit count request. enum = ["complete", "failed", "new", "ready", "running", ...]
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
	/// ACL hit count request parameters
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "request")]
	public LiveToolsAclHitCountGetResponseRequest Request { get; set; } = new();

	/// <summary>
	/// Results of the ACL hit count request, one for each ACL rule.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "acls")]
	public List<LiveToolsAclHitCountGetResponseAcl> Acls { get; set; } = [];
}
