namespace Meraki.Api.Data;

/// <summary>
/// Organization Wireless Opportunistic Pcap License
/// </summary>
[DataContract]
public class OrganizationWirelessOpportunisticPcapLicense
{
	/// <summary>
	/// Name of the network
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Id of the network
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "networkId")]
	public string NetworkId { get; set; } = string.Empty;

	/// <summary>
	/// Whether the network is licensed for MR Cloud PCAP
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "licensed")]
	public bool Licensed { get; set; }
}
