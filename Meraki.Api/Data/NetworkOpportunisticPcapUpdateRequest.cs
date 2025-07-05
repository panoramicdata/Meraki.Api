namespace Meraki.Api.Data;

/// <summary>
/// Network Opportunistic Pcap Update Request
/// </summary>
[DataContract]
public class NetworkOpportunisticPcapUpdateRequest
{
	/// <summary>
	/// Enablement settings
	/// </summary>
	[DataMember(Name = "enablement")]
	public NetworkOpportunisticPcapUpdateRequestEnablement? Enablement { get; set; }
}
