namespace Meraki.Api.Products;

public class Switch
{
	public ISwitchAccessControlLists AccessControlLists { get; internal set; } = null!;

	public ISwitchAlternateManagementInterface AlternateManagementInterface { get; internal set; } = null!;

	public SwitchConfigTemplates ConfigTemplates { get; internal set; } = new();

	public ISwitchDhcpServerPolicy DhcpServerPolicy { get; internal set; } = null!;

	public ISwitchDscpToCosMappings DscpToCosMappings { get; internal set; } = null!;

	public ISwitchMtu Mtu { get; internal set; } = null!;

	public ISwitchPorts Ports { get; internal set; } = null!;

	public ISwitchPortSchedules PortSchedules { get; internal set; } = null!;

	public ISwitchQosRules QosRules { get; internal set; } = null!;

	public SwitchRouting Routing { get; internal set; } = new();

	public ISwitchSettings Settings { get; internal set; } = null!;

	public ISwitchStacks Stacks { get; internal set; } = null!;

	public ISwitchStp Stp { get; internal set; } = null!;

	public ISwitchStormControl StormControl { get; internal set; } = null!;

	public ISwitchWarmSpare WarmSpare { get; internal set; } = null!;
}
