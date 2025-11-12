namespace Meraki.Api.Interfaces.General.Organizations;
/// <summary>
/// I Organizations Devices Syslog Servers Roles
/// </summary>
public interface IOrganizationsDevicesSyslogServersRoles
{
	/// <summary>
	/// Returns roles that can be assigned to a syslog server for a given network.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationDevicesSyslogServersRolesByNetwork")]
	[Get("/organizations/{organizationId}/devices/syslog/servers/roles/byNetwork")]
	Task<OrganizationDevicesSyslogServersRolesByNetwork> GetOrganizationDevicesSyslogServersRolesByNetworkAsync(string organizationId);
}
