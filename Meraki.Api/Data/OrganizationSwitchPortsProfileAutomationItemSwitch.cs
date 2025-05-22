namespace Meraki.Api.Data;

/// <summary>
/// Switch Details
/// </summary>
[DataContract]
public class OrganizationSwitchPortsProfileAutomationItemSwitch
{
	/// <summary>
	/// Switch Serial
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;
}