namespace Meraki.Api.Data;

/// <summary>
/// Identity Pre-Shared Key, which used by node during client device association 
/// </summary>
[DataContract]
public class OrganizationNacAuthorizationPolicySetRuleAuthorizationProfileIpsk
{
	/// <summary>
	/// IPSK value type
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "type")]
	public string Type { get; set; } = string.Empty;

	/// <summary>
	/// IPSK value
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "value")]
	public string Value { get; set; } = string.Empty;
}