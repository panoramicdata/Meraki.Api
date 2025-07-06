namespace Meraki.Api.Data;

/// <summary>
/// Destination port module details
/// </summary>
[DataContract]
public class OrganizationSwitchPortsMirrorConfigurationMirrorDestinationPortModule
{
	/// <summary>
	/// Slot number of the module which will act as destination port
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "slot")]
	public int Slot { get; set; }

	/// <summary>
	/// Module type of the switch
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "type")]
	public string Type { get; set; } = string.Empty;
}