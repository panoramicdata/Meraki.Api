namespace Meraki.Api.Data;

/// <summary>
/// ACL hit count request parameters
/// </summary>
[DataContract]
public class LiveToolsAclHitCountGetResponseRequest
{
	/// <summary>
	/// Device serial number
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;
}