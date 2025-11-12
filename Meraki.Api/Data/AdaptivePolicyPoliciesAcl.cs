namespace Meraki.Api.Data;

/// <summary>
/// Adaptive Policy Policies Acl
/// </summary>
[DataContract]
public class AdaptivePolicyPoliciesAcl
{
	/// <summary>
	/// Id
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// Name
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;
}
