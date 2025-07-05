namespace Meraki.Api.Data;

/// <summary>
/// Counts 
/// </summary>
[DataContract]
public class OrganizationNacAuthorizationPolicySetRuleCounts
{
	/// <summary>
	/// Hits on a rule
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "hits")]
	public int Hits { get; set; }
}