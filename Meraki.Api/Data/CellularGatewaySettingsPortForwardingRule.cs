namespace Meraki.Api.Data;

/// <summary>
/// CellularGatewaySettingsPortForwardingRule
/// </summary>
[DataContract]
public class CellularGatewaySettingsPortForwardingRule
{
	/// <summary>
	/// A descriptive name for the rule
	/// </summary>
	/// <value>A descriptive name for the rule</value>
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// The IP address of the server or device that hosts the internal resource that you wish to make available on the WAN
	/// </summary>
	/// <value>The IP address of the server or device that hosts the internal resource that you wish to make available on the WAN</value>
	[DataMember(Name = "lanIp")]
	public string LanIp { get; set; } = string.Empty;

	/// <summary>
	/// A port or port ranges that will be forwarded to the host on the LAN
	/// </summary>
	/// <value>A port or port ranges that will be forwarded to the host on the LAN</value>
	[DataMember(Name = "publicPort")]
	public string PublicPort { get; set; } = string.Empty;

	/// <summary>
	/// A port or port ranges that will receive the forwarded traffic from the WAN
	/// </summary>
	/// <value>A port or port ranges that will receive the forwarded traffic from the WAN</value>
	[DataMember(Name = "localPort")]
	public string LocalPort { get; set; } = string.Empty;

	/// <summary>
	/// An array of ranges of WAN IP addresses that are allowed to make inbound connections on the specified ports or port ranges.
	/// </summary>
	/// <value>An array of ranges of WAN IP addresses that are allowed to make inbound connections on the specified ports or port ranges.</value>
	[DataMember(Name = "allowedIps")]
	public List<string> AllowedIps { get; set; } = new();

	/// <summary>
	/// TCP or UDP
	/// </summary>
	/// <value>TCP or UDP</value>
	[DataMember(Name = "protocol")]
	public string Protocol { get; set; } = string.Empty;

	/// <summary>
	/// &#x60;any&#x60; or &#x60;restricted&#x60;. Specify the right to make inbound connections on the specified ports or port ranges. If &#x60;restricted&#x60;, a list of allowed IPs is mandatory.
	/// </summary>
	/// <value>&#x60;any&#x60; or &#x60;restricted&#x60;. Specify the right to make inbound connections on the specified ports or port ranges. If &#x60;restricted&#x60;, a list of allowed IPs is mandatory.</value>
	[DataMember(Name = "access")]
	public string Access { get; set; } = string.Empty;
}
