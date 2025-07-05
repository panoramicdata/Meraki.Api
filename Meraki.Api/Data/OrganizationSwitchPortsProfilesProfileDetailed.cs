namespace Meraki.Api.Data;

/// <summary>
/// Organization Switch Ports Profiles Profile Detailed
/// </summary>
[DataContract]
public class OrganizationSwitchPortsProfilesProfileDetailed
{
	/// <summary>
	/// RBAC -> access computed based on current user's administered networks and associated networks w.r.t switch port profiles
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "access")]
	public string Access { get; set; } = string.Empty;

	/// <summary>
	/// When the port profile was created.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "createdAt")]
	public string CreatedAt { get; set; } = string.Empty;

	/// <summary>
	/// Text describing the profile.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "description")]
	public string Description { get; set; } = string.Empty;

	/// <summary>
	/// The name of the profile.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// ID of the network the profile belongs to
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "networkId")]
	public string NetworkId { get; set; } = string.Empty;

	/// <summary>
	/// ID of the profile
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "profileId")]
	public string ProfileId { get; set; } = string.Empty;

	/// <summary>
	/// When the port profile was updated.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "updatedAt")]
	public string UpdatedAt { get; set; } = string.Empty;

	/// <summary>
	/// Whether or not this profile is a organization wide profile
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "isOrganizationWide")]
	public bool IsOrganizationWide { get; set; }

	/// <summary>
	/// Space-seperated list of tags
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "tags")]
	public List<string> Tags { get; set; } = [];

	/// <summary>
	/// Object of Associated Networks
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "networks")]
	public OrganizationSwitchPortsProfilesProfileNetworks Networks { get; set; } = new();

	/// <summary>
	/// Configuration settings for port profile
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "port")]
	public OrganizationSwitchPortsProfilesProfilePort Port { get; set; } = new();

	/// <summary>
	/// Associated switch port details
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "assignedSwitchports")]
	public List<NetworksSwitchPortsProfileAssignedSwitchPort> AssignedSwitchPorts { get; set; } = [];

	/// <summary>
	/// List of ports configured with port profile
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "associatedPorts")]
	public List<NetworksSwitchPortsProfileAssociatedPort> AssociatedPorts { get; set; } = [];

	/// <summary>
	/// List of switches associated with the port profile
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "associatedSwitches")]
	public List<NetworksSwitchPortsProfileAssociatedSwitch> AssociatedSwitches { get; set; } = [];

	/// <summary>
	/// List of Associated Automations
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "automations")]
	public List<NetworksSwitchPortsProfileAutomation> Automations { get; set; } = [];
}
