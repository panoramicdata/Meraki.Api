namespace Meraki.Api.Data;

/// <summary>
/// Syslog server roles
/// </summary>
[DataContract]
public class OrganizationDevicesSyslogServersRolesByNetworkItem
{
	/// <summary>
	/// Contains details about the Network associated with this record
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "network")]
	public OrganizationDevicesSyslogServersRolesByNetworkItemNetwork Network { get; set; } = new();

	/// <summary>
	/// The list of roles that can be assigned to a syslog server for this network
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "availableRoles")]
	public List<OrganizationDevicesSyslogServersRolesByNetworkItemAvailableRole> AvailableRoles { get; set; } = [];
}
