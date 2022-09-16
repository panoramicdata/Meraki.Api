namespace Meraki.Api.Data;

/// <summary>
/// UpdateOrganizationSecurityIntrusionSettings
/// </summary>
[DataContract]
public class OrganizationSecurityIntrusion
{
	/// <summary>
	/// Sets a list of specific SNORT® signatures to allow
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "allowedRules")]
	public List<AllowedRule> AllowedRules { get; set; } = new();
}
