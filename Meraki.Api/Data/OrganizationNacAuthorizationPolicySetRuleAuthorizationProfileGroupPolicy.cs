namespace Meraki.Api.Data;

/// <summary>
/// Group Policy object in Authorization Profile
/// </summary>
[DataContract]
public class OrganizationNacAuthorizationPolicySetRuleAuthorizationProfileGroupPolicy
{
	/// <summary>
	/// Group Policy value type
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "type")]
	public string Type { get; set; } = string.Empty;

	/// <summary>
	/// Group Policy name
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "value")]
	public string Value { get; set; } = string.Empty;
}