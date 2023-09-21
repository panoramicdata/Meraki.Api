namespace Meraki.Api.Data;

/// <summary>
/// Wireless Ethernet Ports Profile
/// </summary>
[DataContract]
public class WirelessEthernetPortsProfileCreateRequest
{
	/// <summary>
	/// Name
	/// </summary>
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Is Default
	/// </summary>
	[DataMember(Name = "isDefault")]
	public bool? IsDefault { get; set; }

	/// <summary>
	/// Ports
	/// </summary>
	[DataMember(Name = "ports")]
	public List<WirelessEthernetPortsProfilePort>? Ports { get; set; }

	/// <summary>
	/// USB Ports
	/// </summary>
	[DataMember(Name = "usbPorts")]
	public List<WirelessEthernetPortsProfileUsbPort>? UsbPorts { get; set; }
}
