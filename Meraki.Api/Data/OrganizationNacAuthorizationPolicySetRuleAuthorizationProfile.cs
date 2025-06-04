namespace Meraki.Api.Data;

/// <summary>
/// Authorization profile associated with the rule
/// </summary>
[DataContract]
public class OrganizationNacAuthorizationPolicySetRuleAuthorizationProfile
{
	/// <summary>
	/// Result of Authorization profile
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "result")]
	public string Result { get; set; } = string.Empty;

	/// <summary>
	/// Adaptive Policy object in Authorization Profile
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "adaptivePolicy")]
	public OrganizationNacAuthorizationPolicySetRuleAuthorizationProfileAdaptivePolicy AdaptivePolicy { get; set; } = new();

	/// <summary>
	/// Group Policy object in Authorization Profile
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "groupPolicy")]
	public OrganizationNacAuthorizationPolicySetRuleAuthorizationProfileGroupPolicy GroupPolicy { get; set; } = new();

	/// <summary>
	/// Identity Pre-Shared Key, which used by node during client device association
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ipsk")]
	public OrganizationNacAuthorizationPolicySetRuleAuthorizationProfileIpsk Ipsk { get; set; } = new();

	/// <summary>
	/// Vlan object in Authorization Profile
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "vlan")]
	public OrganizationNacAuthorizationPolicySetRuleAuthorizationProfileVlan Vlan { get; set; } = new();

	/// <summary>
	/// Voice domain object in Authorization Profile
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "voiceDomain")]
	public OrganizationNacAuthorizationPolicySetRuleAuthorizationProfileVoiceDomain VoiceDomain { get; set; } = new();
}
