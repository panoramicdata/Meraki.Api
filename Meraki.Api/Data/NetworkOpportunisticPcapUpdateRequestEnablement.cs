namespace Meraki.Api.Data;

/// <summary>
/// Enablement settings
/// </summary>
[DataContract]
public class NetworkOpportunisticPcapUpdateRequestEnablement
{
	/// <summary>
	/// Controls Opportunistic Pcap enablement within a network:
	/// <list type="bullet">
	/// <item>0 - Disabled</item>
	/// <item>1 - Enabled</item>
	/// <item>2 - Enabled only for some APs/Tags</item>
	/// </list>
	/// </summary>
	[DataMember(Name = "networkWide")]
	public int? NetworkWide { get; set; }

	/// <summary>
	/// AP serials for which Opportunistic Pcap should be enabled. Any list of serial sent here will overwrite the existing list of enabled APs.
	/// <para>Do not send anything to keep the previous settings. Valid only when opportunistic pcap is not set at network level(i.e.networkWide = 2)</para>
	/// </summary>
	[DataMember(Name = "serials")]
	public List<string>? Serials { get; set; }

	/// <summary>
	/// AP tags for which Opportunistic Pcap should be enabled. Any list of tags sent here will overwrite the existing list of enabled tags.
	/// <para>Do not send anything to keep the previous settings.Valid only when opportunistic pcap is not set at network level(i.e.networkWide = 2)</para>
	/// </summary>
	[DataMember(Name = "tags")]
	public List<string>? Tags { get; set; }
}