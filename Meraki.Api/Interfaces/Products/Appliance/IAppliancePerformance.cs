namespace Meraki.Api.Interfaces.Products.Appliance;

public interface IAppliancePerformance
{
	/// <summary>
	/// Return the performance score for a single MX
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	[Get("/devices/{serial}/appliance/performance")]
	Task<Performance> GetDeviceAppliancePerformanceAsync(
		[AliasAs("serial")] string serial,
		CancellationToken cancellationToken = default);
}
