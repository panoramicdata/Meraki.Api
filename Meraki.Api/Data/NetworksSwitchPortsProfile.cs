namespace Meraki.Api.Data;

/// <summary>
/// NetworksSwitchPortsProfile
/// </summary>
[DataContract]
public class NetworksSwitchPortsProfile
{
	/// <summary>
	/// ID of the profile
	/// </summary>
	[ApiKey]
	[DataMember(Name = "profileId")]
	[ApiAccess(ApiAccess.Read)]
	public string? ProfileId { get; set; }

	/// <summary>
	/// ID of the network the profile belongs to
	/// </summary>
	[DataMember(Name = "networkId")]
	[ApiAccess(ApiAccess.Read)]
	public string? NetworkId { get; set; }

	/// <summary>
	/// The name of the profile.
	/// </summary>
	[DataMember(Name = "name")]
	[ApiAccess(ApiAccess.ReadWrite)]
	public string? Name { get; set; }

	/// <summary>
	/// Text describing the profile.
	/// </summary>
	[DataMember(Name = "description")]
	[ApiAccess(ApiAccess.ReadWrite)]
	public string? Description { get; set; }

	/// <summary>
	/// Space-seperated list of tags
	/// </summary>
	[DataMember(Name = "tags")]
	[ApiAccess(ApiAccess.ReadWrite)]
	public List<string>? Tags { get; set; }

	/// <summary>
	/// List of ports configured with port profile
	/// </summary>
	[DataMember(Name = "associatedPorts")]
	[ApiAccess(ApiAccess.ReadWrite)]
	public List<NetworksSwitchPortsProfileAssociatedPort>? AssociatedPorts { get; set; }

	/// <summary>
	/// List of switches associated with the port profile
	/// </summary>
	[DataMember(Name = "associatedSwitches")]
	[ApiAccess(ApiAccess.ReadWrite)]
	public List<NetworksSwitchPortsProfileAssociatedSwitch>? AssociatedSwitches { get; set; }

	/// <summary>
	/// Associated switch ports details
	/// </summary>
	[DataMember(Name = "assignedSwitchports")]
	[ApiAccess(ApiAccess.ReadWrite)]
	public List<NetworksSwitchPortsProfileAssignedSwitchPort>? AssignedSwitchports { get; set; }

	/// <summary>
	/// When the port profile was created.
	/// </summary>
	[DataMember(Name = "createdAt")]
	[ApiAccess(ApiAccess.ReadWrite)]
	public DateTime? CreatedAt { get; set; }

	/// <summary>
	/// When the port profile was updated.
	/// </summary>
	[DataMember(Name = "updatedAt")]
	[ApiAccess(ApiAccess.ReadWrite)]
	public DateTime? UpdatedAt { get; set; }

	/// <summary>
	/// Port profile attributes
	/// </summary>
	[DataMember(Name = "port")]
	[ApiAccess(ApiAccess.ReadWrite)]
	public NetworksSwitchPortsProfilePort? Port { get; set; }

	/// <summary>
	/// Whether or not this profile is a organization wide profile
	/// </summary>
	[DataMember(Name = "isOrganizationWide")]
	[ApiAccess(ApiAccess.ReadWrite)]
	public bool? IsOrganizationWide { get; set; }

	/// <summary>
	/// Object of Associated Networks
	/// </summary>
	[DataMember(Name = "networks")]
	[ApiAccess(ApiAccess.ReadWrite)]
	public NetworksSwitchPortsProfileNetworks? Networks { get; set; }

	/// <summary>
	/// List of Associated Automations
	/// </summary>
	[DataMember(Name = "automations")]
	[ApiAccess(ApiAccess.ReadWrite)]
	public List<NetworksSwitchPortsProfileAutomation>? Automations { get; set; }

	/// <summary>
	/// RBAC -> access computed based on current user's administered networks & associated networks w.r.t switch port profiles
	/// </summary>
	[DataMember(Name = "access")]
	[ApiAccess(ApiAccess.ReadWrite)]
	public string? Access { get; set; }
}