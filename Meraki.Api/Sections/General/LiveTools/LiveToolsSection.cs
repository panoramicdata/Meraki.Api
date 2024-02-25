using Meraki.Api.Interfaces.General.LiveTools;

namespace Meraki.Api.Sections.General.LiveTools;

public partial class LiveToolsSection
{
	internal ILiveToolsArpTable ArpTable { get; set; } = null!;

	internal ILiveToolsCableTest CableTest { get; set; } = null!;

	internal ILiveToolsPing Ping { get; set; } = null!;

	internal ILiveToolsPingDevice PingDevice { get; set; } = null!;

	internal ILiveToolsWakeOnLan WakeOnLan { get; set; } = null!;

}
