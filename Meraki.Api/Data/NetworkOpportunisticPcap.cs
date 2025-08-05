namespace Meraki.Api.Data;

/// <summary>
/// Network Opportunistic Pcap
/// </summary>
[DataContract]
public class NetworkOpportunisticPcap
{
	/// <summary>
	/// Name of the network
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Id of the network
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "networkId")]
	public string NetworkId { get; set; } = string.Empty;

	/// <summary>
	/// Enablement settings
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "enablement")]
	public NetworkOpportunisticPcapEnablement Enablement { get; set; } = new();
}
