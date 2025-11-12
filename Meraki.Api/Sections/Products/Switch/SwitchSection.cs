namespace Meraki.Api.Sections.Products.Switch;

/// <summary>
/// Provides access to switch API endpoints
/// </summary>
public class SwitchSection
{
	/// <summary>
	/// Return the access control lists for a MS network
	/// </summary>

	public ISwitchAccessControlLists AccessControlLists { get; internal set; } = null!;
	/// <summary>
	/// List the access policies for a switch network.
	/// </summary>

	public ISwitchAccessPolicies AccessPolicies { get; internal set; } = null!;
	/// <summary>
	/// Return the switch alternate management interface for the network
	/// </summary>

	public ISwitchAlternateManagementInterface AlternateManagementInterface { get; internal set; } = null!;
	/// <summary>
	/// Clone port-level and some switch-level configuration settings from a source switch to one or more target switches.
	/// </summary>

	public ISwitchDevices Devices { get; internal set; } = null!;
	/// <summary>
	/// Gets the config templates
	/// </summary>

	public SwitchConfigTemplatesSection ConfigTemplates { get; internal set; } = new();
	/// <summary>
	/// Return the DHCP server policy
	/// </summary>

	public ISwitchDhcpServerPolicy DhcpServerPolicy { get; internal set; } = null!;
	/// <summary>
	/// Return the DSCP to CoS mappings
	/// </summary>

	public ISwitchDscpToCosMappings DscpToCosMappings { get; internal set; } = null!;
	/// <summary>
	/// Return the MTU configuration
	/// </summary>

	public ISwitchMtu Mtu { get; internal set; } = null!;
	/// <summary>
	/// List link aggregation groups
	/// </summary>

	public ISwitchLinkAggregations LinkAggregations { get; internal set; } = null!;
	/// <summary>
	/// List the switch ports for a switch
	/// </summary>

	public ISwitchPorts Ports { get; internal set; } = null!;
	/// <summary>
	/// List switch port schedules
	/// </summary>

	public ISwitchPortSchedules PortSchedules { get; internal set; } = null!;
	/// <summary>
	/// List quality of service rules
	/// </summary>

	public ISwitchQosRules QosRules { get; internal set; } = null!;
	/// <summary>
	/// Gets the routing
	/// </summary>

	public SwitchRoutingSection Routing { get; internal set; } = new();
	/// <summary>
	/// Returns the switch network settings
	/// </summary>

	public ISwitchSettings Settings { get; internal set; } = null!;
	/// <summary>
	/// List the switch stacks in a network
	/// </summary>

	public ISwitchStacks Stacks { get; internal set; } = null!;
	/// <summary>
	/// Returns STP settings
	/// </summary>

	public ISwitchStp Stp { get; internal set; } = null!;
	/// <summary>
	/// Return the storm control configuration for a switch network
	/// </summary>

	public ISwitchStormControl StormControl { get; internal set; } = null!;
	/// <summary>
	/// Return warm spare configuration for a switch
	/// </summary>

	public ISwitchWarmSpare WarmSpare { get; internal set; } = null!;
}
