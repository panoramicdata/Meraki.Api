namespace Meraki.Api.Interfaces.General.LiveTools;

/// <summary>
/// I Live Tools Arp Table
/// </summary>
public interface ILiveToolsArpTable
{
	/// <summary>
	/// Enqueue a job to perform a ARP table request for the device. This endpoint currently supports switches.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="createDeviceLiveToolsArpTable">Body</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("createDeviceLiveToolsArpTable")]
	[Post("/devices/{serial}/liveTools/arpTable")]
	Task<LiveToolsArpTable> CreateDeviceLiveToolsArpTableAsync(
		string serial,
		[Body] LiveToolsArpTableCreate createDeviceLiveToolsArpTable,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Return an ARP table live tool job.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="arpTableId">Arp table ID</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getDeviceLiveToolsArpTable")]
	[Get("/devices/{serial}/liveTools/arpTable/{arpTableId}")]
	Task<LiveToolsArpTableResult> GetDeviceLiveToolsArpTableAsync(
		string serial,
		string arpTableId,
		CancellationToken cancellationToken = default);
}
