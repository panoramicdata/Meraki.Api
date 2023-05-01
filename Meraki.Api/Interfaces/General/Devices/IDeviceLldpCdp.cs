namespace Meraki.Api.Interfaces.General.Devices;

public interface IDeviceLldpCdp
{
	/// <summary>
	/// List LLDP and CDP information for a device
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="timespan">The timespan for which LLDP and CDP information will be fetched. Must be in seconds and less than or equal to a month (2592000 seconds). LLDP and CDP information is sent to the Meraki dashboard every 10 minutes. In instances where this LLDP and CDP information matches an existing entry in the Meraki dashboard, the data is updated once every two hours. Meraki recommends querying LLDP and CDP information at an interval slightly greater than two hours, to ensure that unchanged CDP / LLDP information can be queried consistently. (optional)</param>
	[ApiOperationId("getDeviceLldpCdp")]
	[Get("/devices/{serial}/lldpCdp")]
	Task<LldpCdp> GetDeviceLldpCdpAsync(
		string serial,
		int? timespan = null,
		CancellationToken cancellationToken = default);
}
