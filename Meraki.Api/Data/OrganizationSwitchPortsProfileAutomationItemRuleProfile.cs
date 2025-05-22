namespace Meraki.Api.Data;

/// <summary>
/// Profile to be applied
/// </summary>
[DataContract]
public class OrganizationSwitchPortsProfileAutomationItemRuleProfile
{
	/// <summary>
	/// Switch port Profile Id
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// Default port profile name
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;
}