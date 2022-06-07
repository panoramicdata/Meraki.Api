namespace Meraki.Api.Interfaces.Products.Appliance;

public interface IApplianceVmxAuthenticationToken
{
	/// <summary>
	/// Generate a new vMX authentication token
	/// </summary>
	/// <param name="serial">The device serial number</param>
	[Post("/devices/{serial}/appliance/vmx/authenticationToken")]
	Task<VmxAuthenticationToken> CreateDeviceApplianceVmxAuthenticationTokenAsync(
		[AliasAs("serial")] string serial,
		CancellationToken cancellationToken = default);
}
