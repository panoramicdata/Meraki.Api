using Meraki.Api.Interfaces.General.LiveTools;

namespace Meraki.Api.Sections.General.LiveTools;

public class LiveToolsSection
{
	public ILiveToolsAclHitCount AclHitCount { get; set; } = null!;

	public ILiveToolsArpTable ArpTable { get; set; } = null!;

	public ILiveToolsCableTest CableTest { get; set; } = null!;

	public ILiveToolsCyclePort CyclePort { get; set; } = null!;

	public ILiveToolsDhcpLeases DhcpLeases { get; set; } = null!;

	public ILiveToolsMulticastRouting MulticastRouting { get; set; } = null!;

	public ILiveToolsPing Ping { get; set; } = null!;

	public ILiveToolsPingDevice PingDevice { get; set; } = null!;

	public ILiveToolsOspfNeighbors OspfNeighbors { get; set; } = null!;

	public ILiveToolsRoutingTable RoutingTable { get; set; } = null!;

	public ILiveToolsSpeedTest SpeedTest { get; set; } = null!;

	public ILiveToolsTraceRoute TraceRoute { get; set; } = null!;

	public ILiveToolsWakeOnLan WakeOnLan { get; set; } = null!;

	public ILiveToolsThroughputTest ThroughputTest { get; set; } = null!;
}
