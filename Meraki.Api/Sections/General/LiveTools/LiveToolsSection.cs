using Meraki.Api.Interfaces.General.LiveTools;

namespace Meraki.Api.Sections.General.LiveTools;

public partial class LiveToolsSection
{
	internal ILiveToolsPing Ping { get; set; } = null!;

	internal ILiveToolsPingDevice PingDevice { get; set; } = null!;
}
