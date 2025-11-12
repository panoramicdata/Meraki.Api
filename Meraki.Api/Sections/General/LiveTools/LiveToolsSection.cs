using Meraki.Api.Interfaces.General.LiveTools;

namespace Meraki.Api.Sections.General.LiveTools;

/// <summary>
/// Provides access to live tools API endpoints
/// </summary>
public class LiveToolsSection
{
	/// <summary>
	/// Enqueue a job to perform an ACL hit count for the device. This endpoint has a sustained rate limit of one request every five seconds per device, with an allowed burst of five requests.
	/// </summary>

	public ILiveToolsAclHitCount AclHitCount { get; set; } = null!;

	/// <summary>
	/// Enqueue a job to perform a ARP table request for the device. This endpoint currently supports switches.
	/// </summary>

	public ILiveToolsArpTable ArpTable { get; set; } = null!;

	/// <summary>
	/// Enqueue a job to perform a cable test for the device on the specified ports.
	/// </summary>

	public ILiveToolsCableTest CableTest { get; set; } = null!;

	/// <summary>
	/// Enqueue a job to perform a cycle port for the device on the specified ports. This endpoint has a sustained rate limit of one request every five seconds per device, with an allowed burst of five requests.
	/// </summary>

	public ILiveToolsCyclePort CyclePort { get; set; } = null!;

	/// <summary>
	/// Return a DHCP leases live tool job.
	/// </summary>

	public ILiveToolsDhcpLeases DhcpLeases { get; set; } = null!;

	/// <summary>
	/// Enqueue a job to blink LEDs on a device. This endpoint has a rate limit of one request every 10 seconds.
	/// </summary>

	public ILiveToolsLeds Leds { get; set; } = null!;

	/// <summary>
	/// Return a MAC table live tool job.
	/// </summary>

	public ILiveToolsMacTable MacTable { get; set; } = null!;

	/// <summary>
	/// Return a Multicast routing live tool job.
	/// </summary>

	public ILiveToolsMulticastRouting MulticastRouting { get; set; } = null!;

	/// <summary>
	/// Enqueue a job to ping a target host from the device
	/// </summary>

	public ILiveToolsPing Ping { get; set; } = null!;

	/// <summary>
	/// Enqueue a job to check connectivity status to the device
	/// </summary>

	public ILiveToolsPingDevice PingDevice { get; set; } = null!;

	/// <summary>
	/// Return an OSPF neighbors live tool job.
	/// </summary>

	public ILiveToolsOspfNeighbors OspfNeighbors { get; set; } = null!;

	/// <summary>
	/// Return an routing table live tool job.
	/// </summary>

	public ILiveToolsRoutingTable RoutingTable { get; set; } = null!;

	/// <summary>
	/// Returns a speed test result in megabits per second. If test is not complete, no results are present.
	/// </summary>

	public ILiveToolsSpeedTest SpeedTest { get; set; } = null!;

	/// <summary>
	/// Return a trace route job
	/// </summary>

	public ILiveToolsTraceRoute TraceRoute { get; set; } = null!;

	/// <summary>
	/// Enqueue a job to send a Wake-on-LAN packet from the device
	/// </summary>

	public ILiveToolsWakeOnLan WakeOnLan { get; set; } = null!;

	/// <summary>
	/// Enqueue a job to test a device throughput, the test will run for 10 secs to test throughput
	/// </summary>

	public ILiveToolsThroughputTest ThroughputTest { get; set; } = null!;
}
