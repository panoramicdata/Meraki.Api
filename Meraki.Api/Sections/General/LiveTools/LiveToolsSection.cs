﻿using Meraki.Api.Interfaces.General.LiveTools;

namespace Meraki.Api.Sections.General.LiveTools;

public class LiveToolsSection
{
	public ILiveToolsArpTable ArpTable { get; set; } = null!;

	public ILiveToolsCableTest CableTest { get; set; } = null!;

	public ILiveToolsPing Ping { get; set; } = null!;

	public ILiveToolsPingDevice PingDevice { get; set; } = null!;

	public ILiveToolsWakeOnLan WakeOnLan { get; set; } = null!;

	public ILiveToolsThroughputTest ThroughputTest { get; set; } = null!;
}
