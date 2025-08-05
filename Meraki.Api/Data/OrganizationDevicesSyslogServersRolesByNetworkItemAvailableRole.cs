namespace Meraki.Api.Data;

/// <summary>
/// Role that can be assigned to a syslog server for this network
/// </summary>
[DataContract]
public class OrganizationDevicesSyslogServersRolesByNetworkItemAvailableRole
{
	/// <summary>
	/// The user friendly name of the role
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// The enum value of the role that can be assigned to a syslog server
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "value")]
	public string Value { get; set; } = string.Empty;
}