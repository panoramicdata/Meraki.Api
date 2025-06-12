namespace Meraki.Api.Data;

/// <summary>
/// Voice domain object in Authorization Profile 
/// </summary>
[DataContract]
public class OrganizationNacAuthorizationPolicySetRuleAuthorizationProfileVoiceDomain
{
	/// <summary>
	/// Voice Domain value type
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "type")]
	public string Type { get; set; } = string.Empty;

	/// <summary>
	/// Voice Domain value - true or false
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "value")]
	public string Value { get; set; } = string.Empty;
}