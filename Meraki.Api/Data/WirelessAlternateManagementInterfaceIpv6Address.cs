namespace Meraki.Api.Data;

/// <summary>
/// WirelessAlternateManagementInterfaceIpv6Address
/// </summary>
[DataContract]
public class WirelessAlternateManagementInterfaceIpv6Address
{
	/// <summary>
	/// The IP protocol used for the address
	/// </summary>
	[DataMember(Name = "protocol")]
	public IpProtocolType? Protocol { get; set; }

	/// <summary>
	/// The type of address assignment. Either static or dynamic.
	/// </summary>
	public WirelessAlternateManagementInterfaceIpv6AssignmentMode? AssignmentMode { get; set; }

	/// <summary>
	/// The IP address configured for the alternate management interface
	/// </summary>
	public string? Address { get; set; }

	/// <summary>
	/// The gateway address configured for the alternate managment interface
	/// </summary>
	public string? Gateway { get; set; }

	/// <summary>
	/// The IPv6 prefix length of the IPv6 interface. Required if IPv6 object is included.
	/// </summary>
	public string? Prefix { get; set; }

	/// <summary>
	/// The DNS servers settings for this address.
	/// </summary>
	public WirelessAlternateManagementInterfaceIpv6Nameservers? Nameservers { get; set; }
}
