namespace Meraki.Api.Data;

/// <summary>
/// Configuration details for the network 
/// </summary>
[DataContract]
public class OrganizationSnmpTrapByNetworkNetwork
{
	/// <summary>
	/// ID of the network
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// Name of the network
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;
}