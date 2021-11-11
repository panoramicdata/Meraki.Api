namespace Meraki.Api.Products;

public class Switch
{
	public ISwitchAcls AccessControlLists { get; internal set; } = null!;

	public ISwitchPorts Ports { get; internal set; } = null!;

	public ISwitchPortSchedules PortSchedules { get; internal set; } = null!;

	public SwitchConfigTemplates ConfigTemplates { get; internal set; } = new();

	public ISwitchSettings Settings { get; internal set; } = null!;

	public ISwitchStacks Stacks { get; internal set; } = null!;
}
