namespace Meraki.Api.Data;

/// <summary>
/// Enablement settings
/// </summary>
[DataContract]
public class NetworkOpportunisticPcapEnablement
{
	/// <summary>
	/// Controls Opportunistic Pcap enablement within a network:
	/// <list type="bullet">
	/// <item>0 - Disabled</item>
	/// <item>1 - Enabled</item>
	/// <item>2 - Enabled only for some APs/Tags</item>
	/// </list>
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "networkWide")]
	public int NetworkWide { get; set; }

	/// <summary>
	/// AP serials for which Opportunistic Pcap is enabled (only when unspecified at network level)
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serials")]
	public List<string> Serials { get; set; } = [];

	/// <summary>
	/// AP tags for which Opportunistic Pcap is enabled (only when unspecified at network level)
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "tags")]
	public List<string> Tags { get; set; } = [];
}