namespace Meraki.Api.Data;

/// <summary>
/// List of port mirror configurations in an organization by switch
/// </summary>
[DataContract]
public class OrganizationSwitchPortsMirrorConfiguration
{
	/// <summary>
	/// Switch serial number
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// Warnings from traffic mirror configuration changes
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "warnings")]
	public List<string> Warnings { get; set; } = [];

	/// <summary>
	/// Switch port mirror configurations
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "mirror")]
	public OrganizationSwitchPortsMirrorConfigurationMirror Mirror { get; set; } = new();

	/// <summary>
	/// Network of the switch
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "network")]
	public OrganizationSwitchPortsMirrorConfigurationNetwork Network { get; set; } = new();
}
