namespace Meraki.Api.Data;

/// <summary>
/// Source port module details
/// </summary>
[DataContract]
public class OrganizationSwitchPortsMirrorConfigurationMirrorSourcePortModule
{
	/// <summary>
	/// Slot number of the module which will act as source port
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "slot")]
	public int Slot { get; set; }

	/// <summary>
	/// Module type of the switch port
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "type")]
	public string Type { get; set; } = string.Empty;
}