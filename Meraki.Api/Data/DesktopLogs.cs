namespace Meraki.Api.Data;

/// <summary>
/// Desktop logs
/// </summary>
[DataContract]
public class DesktopLogs
{
	/// <summary>
	/// Measured at
	/// </summary>
	[DataMember(Name = "measuredAt")]
	public DateTime MeasuredAt { get; set; }

	/// <summary>
	/// User
	/// </summary>
	[DataMember(Name = "user")]
	public string User { get; set; } = string.Empty;

	/// <summary>
	/// Network device
	/// </summary>
	[DataMember(Name = "networkDevice")]
	public string NetworkDevice { get; set; } = string.Empty;

	/// <summary>
	/// Network driver
	/// </summary>
	[DataMember(Name = "networkDriver")]
	public string NetworkDriver { get; set; } = string.Empty;

	/// <summary>
	/// Wifi channel
	/// </summary>
	[DataMember(Name = "wifiChannel")]
	public string WifiChannel { get; set; } = string.Empty;

	/// <summary>
	/// Wifi auth
	/// </summary>
	[DataMember(Name = "wifiAuth")]
	public string WifiAuth { get; set; } = string.Empty;

	/// <summary>
	/// Wifi bssid
	/// </summary>
	[DataMember(Name = "wifiBssid")]
	public string WifiBssid { get; set; } = string.Empty;

	/// <summary>
	/// Wifi ssid
	/// </summary>
	[DataMember(Name = "wifiSsid")]
	public string WifiSsid { get; set; } = string.Empty;

	/// <summary>
	/// Wifi rssi
	/// </summary>
	[DataMember(Name = "wifiRssi")]
	public string WifiRssi { get; set; } = string.Empty;

	/// <summary>
	/// Wifi noise
	/// </summary>
	[DataMember(Name = "wifiNoise")]
	public string WifiNoise { get; set; } = string.Empty;

	/// <summary>
	/// DHCP server
	/// </summary>
	[DataMember(Name = "dhcpServer")]
	public string DhcpServer { get; set; } = string.Empty;

	/// <summary>
	/// Ip
	/// </summary>
	[DataMember(Name = "ip")]
	public string Ip { get; set; } = string.Empty;

	/// <summary>
	/// Network MTU
	/// </summary>
	[DataMember(Name = "networkMTU")]
	public string NetworkMTU { get; set; } = string.Empty;

	/// <summary>
	/// Subnet
	/// </summary>
	[DataMember(Name = "subnet")]
	public string Subnet { get; set; } = string.Empty;

	/// <summary>
	/// Gateway
	/// </summary>
	[DataMember(Name = "gateway")]
	public string Gateway { get; set; } = string.Empty;

	/// <summary>
	/// Public ip
	/// </summary>
	[DataMember(Name = "publicIp")]
	public string PublicIp { get; set; } = string.Empty;

	/// <summary>
	/// DNS server
	/// </summary>
	[DataMember(Name = "dnsServer")]
	public string DnsServer { get; set; } = string.Empty;

	/// <summary>
	/// Ts
	/// </summary>
	[DataMember(Name = "ts")]
	public string Ts { get; set; } = string.Empty;
}
