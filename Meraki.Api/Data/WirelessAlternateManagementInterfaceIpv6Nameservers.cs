namespace Meraki.Api.Data;

/// <summary>
/// The DNS server settings
/// </summary>
[DataContract]
public class WirelessAlternateManagementInterfaceIpv6Nameservers
{
	/// <summary>
	/// Up to 2 nameserver addresses to use, ordered in priority from highest to lowest priority
	/// </summary>
	[DataMember(Name = "addresses")]
	public List<string>? Addresses { get; set; }
}
