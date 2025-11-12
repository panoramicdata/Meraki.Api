namespace Meraki.Api.Interfaces.Products.Switch;

/// <summary>
/// I Switch Devices
/// </summary>
public interface ISwitchDevices
{
	/// <summary>
	/// Clone port-level and some switch-level configuration settings from a source switch to one or more target switches.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="cloneOrganizationSwitchDevices">Body for cloning an organization's switch devices</param>
	/// <param name="cancellationToken"></param>
	[Post("/organizations/{organizationId}/switch/devices/clone")]
	Task<CloneOrganizationSwitchDevices> CloneOrganizationSwitchDevicesAsync(
		string organizationId,
		[Body] CloneOrganizationSwitchDevices cloneOrganizationSwitchDevices,
		CancellationToken cancellationToken = default
		);
}
