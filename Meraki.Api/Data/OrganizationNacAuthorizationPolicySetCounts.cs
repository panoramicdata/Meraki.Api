namespace Meraki.Api.Data;

/// <summary>
/// Counts
/// </summary>
[DataContract]
public class OrganizationNacAuthorizationPolicySetCounts
{
	/// <summary>
	/// Hits on an authorization policy set
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "hits")]
	public int Hits { get; set; }
}