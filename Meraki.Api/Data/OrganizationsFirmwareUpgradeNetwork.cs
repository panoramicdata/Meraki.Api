namespace Meraki.Api.Data;

/// <summary>
/// Network of the upgrade
/// </summary>
[DataContract]
public class OrganizationsFirmwareUpgradeNetwork
{
	/// <summary>
	/// ID of network
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// The network
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;
}