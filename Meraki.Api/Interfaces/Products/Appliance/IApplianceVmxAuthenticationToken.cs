namespace Meraki.Api.Interfaces.Products.Appliance;

/// <summary>
/// I Appliance Vmx Authentication Token
/// </summary>
public interface IApplianceVmxAuthenticationToken
{
	/// <summary>
	/// Generate a new vMX authentication token
	/// </summary>
	/// <param name="serial">The device serial number</param>
	/// <param name="cancellationToken"></param>
	[Post("/devices/{serial}/appliance/vmx/authenticationToken")]
	Task<VmxAuthenticationToken> CreateDeviceApplianceVmxAuthenticationTokenAsync(
		string serial,
		CancellationToken cancellationToken = default);
}
