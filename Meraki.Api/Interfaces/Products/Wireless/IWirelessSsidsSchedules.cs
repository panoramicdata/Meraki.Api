namespace Meraki.Api.Interfaces.Products.Wireless;

public interface IWirelessSsidsSchedules
{
	/// <summary>
	/// List the outage schedule for the SSID
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="number">The SSID number</param>
	[Get("/networks/{networkId}/wireless/ssids/{number}/schedules")]
	Task<WirelessSsidOutageSchedule> GetNetworkWirelessSsidSchedulesAsync(
		string networkId,
		string number,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update the outage schedule for the SSID
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="number">The SSID number</param>
	[Put("/networks/{networkId}/wireless/ssids/{number}/schedules")]
	Task<WirelessSsidOutageSchedule> UpdateNetworkWirelessSsidSchedulesAsync(
		string networkId,
		string number,
		[Body] WirelessSsidOutageSchedule updateNetworkWirelessSsidSchedules,
		CancellationToken cancellationToken = default
		);
}
