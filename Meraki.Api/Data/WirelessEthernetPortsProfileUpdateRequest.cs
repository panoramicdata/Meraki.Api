namespace Meraki.Api.Data;

/// <summary>
/// Wireless Ethernet Ports Profile Update Request
/// </summary>
[DataContract]
public class WirelessEthernetPortsProfileUpdateRequest
{
	/// <summary>
	/// Name
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string? Name { get; set; }

	/// <summary>
	/// Ports
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "ports")]
	public List<WirelessEthernetPortsProfilePort>? Ports { get; set; }

	/// <summary>
	/// USB Ports
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "usbPorts")]
	public List<WirelessEthernetPortsProfileUsbPort>? UsbPorts { get; set; }
}
