using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// Vpn status
/// </summary>
[DataContract]
public class VpnStatus
{
	/// <summary>
	/// Network Id
	/// </summary>
	[DataMember(Name = "networkId")]
	public string NetworkId { get; set; } = string.Empty;

	/// <summary>
	/// Network name
	/// </summary>
	[DataMember(Name = "networkName")]
	public string NetworkName { get; set; } = string.Empty;

	/// <summary>
	/// Device serial
	/// </summary>
	[DataMember(Name = "deviceSerial")]
	public string DeviceSerial { get; set; } = string.Empty;

	/// <summary>
	/// Device status
	/// </summary>
	[DataMember(Name = "deviceStatus")]
	public string DeviceStatus { get; set; } = string.Empty;

	/// <summary>
	/// Uplinks
	/// </summary>
	[DataMember(Name = "uplinks")]
	public List<VpnStatusUplink> Uplinks { get; set; } = new();

	/// <summary>
	/// VPN mode
	/// </summary>
	[DataMember(Name = "vpnMode")]
	public string VpnMode { get; set; } = string.Empty;

	/// <summary>
	/// Exported subnets
	/// </summary>
	[DataMember(Name = "exportedSubnets")]
	public List<ExportedSubnet> ExportedSubnets { get; set; } = new();

	/// <summary>
	/// Meraki VPN peers
	/// </summary>
	[DataMember(Name = "merakiVpnPeers")]
	public List<MerakiVpnPeers> MerakiVpnPeers { get; set; } = new();

	/// <summary>
	/// Third party VPN peers
	/// </summary>
	[DataMember(Name = "thirdPartyVpnPeers")]
	public List<ThirdPartyVpnPeers> ThirdPartyVpnPeers { get; set; } = new();
}
