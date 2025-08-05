namespace Meraki.Api.Data;

/// <summary>
/// Organization Devices Syslog Servers Roles By Network
/// </summary>
[DataContract]
public class OrganizationDevicesSyslogServersRolesByNetwork
{
	/// <summary>
	/// Metadata relevant to the paginated dataset
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "meta")]
	public OrganizationDevicesSyslogServersRolesByNetworkMetadata Meta { get; set; } = new();

	/// <summary>
	/// Outer container to hold the different syslog server roles per network
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "items")]
	public List<OrganizationDevicesSyslogServersRolesByNetworkItem> Items { get; set; } = [];
}
