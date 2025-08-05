namespace Meraki.Api.Data;

/// <summary>
/// Contains details about the Network associated with this record
/// </summary>
[DataContract]
public class OrganizationDevicesSyslogServersRolesByNetworkItemNetwork
{
	/// <summary>
	/// The ID of the network 
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;
}