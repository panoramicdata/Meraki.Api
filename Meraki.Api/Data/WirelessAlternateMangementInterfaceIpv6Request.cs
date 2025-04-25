namespace Meraki.Api.Data;

/// <summary>
/// WirelessAlternateMangementInterfaceIpv6Request
/// </summary>
public class WirelessAlternateMangementInterfaceIpv6Request
{
	/// <summary>
	/// Configured alternate management interface addresses
	/// </summary>
	public List<WirelessAlternateManagementInterfaceIpv6Address>? Addresses { get; set; }
}
