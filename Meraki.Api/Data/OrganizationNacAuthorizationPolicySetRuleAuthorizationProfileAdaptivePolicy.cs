namespace Meraki.Api.Data;

/// <summary>
/// Adaptive Policy object in Authorization Profile
/// </summary>
[DataContract]
public class OrganizationNacAuthorizationPolicySetRuleAuthorizationProfileAdaptivePolicy
{
	/// <summary>
	/// Adaptive Policy value type 
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "type")]
	public string Type { get; set; } = string.Empty;

	/// <summary>
	/// Adaptive Policy name
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "value")]
	public string Value { get; set; } = string.Empty;
}