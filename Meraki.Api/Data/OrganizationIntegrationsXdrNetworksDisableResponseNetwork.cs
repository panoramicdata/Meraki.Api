namespace Meraki.Api.Data;

/// <summary>
/// Network that has XDR disabled
/// </summary>
[DataContract]
public class OrganizationIntegrationsXdrNetworksDisableResponseNetwork
{
	/// <summary>
	/// The name of the network
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Network ID
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "networkId")]
	public string NetworkId { get; set; } = string.Empty;

	/// <summary>
	/// Represents whether XDR is enabled for the network
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }

	/// <summary>
	/// Represents whether the network is eligible for XDR
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "isEligible")]
	public bool IsEligible { get; set; }

	/// <summary>
	/// List of products that have XDR disabled
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "productTypes")]
	public List<string> ProductTypes { get; set; } = [];
}