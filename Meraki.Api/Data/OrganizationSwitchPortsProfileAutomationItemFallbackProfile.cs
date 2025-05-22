namespace Meraki.Api.Data;

/// <summary>
/// Fallback port profile
/// </summary>
[DataContract]
public class OrganizationSwitchPortsProfileAutomationItemFallbackProfile
{
	/// <summary>
	/// Default port profile Id
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