namespace Meraki.Api.Data;

/// <summary>
/// WirelessAlternateMangementInterfaceIpv6Request
/// </summary>
[DataContract]
public class WirelessAlternateMangementInterfaceIpv6Data
{
	/// <summary>
	/// Configured alternate management interface addresses
	/// </summary>
	[DataMember(Name = "addresses")]
	public List<WirelessAlternateManagementInterfaceIpv6Address>? Addresses { get; set; }
}
