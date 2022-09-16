namespace Meraki.Api.Data;

/// <summary>
/// Event data
/// </summary>
[DataContract]
public class EventData
{
	/// <summary>
	/// Aid
	/// </summary>
	[DataMember(Name = "aid")]
	public string? Aid { get; set; }

	/// <summary>
	/// Alarm ID
	/// </summary>
	[DataMember(Name = "alarm_id")]
	public string? AlarmId { get; set; }

	/// <summary>
	/// ARP response
	/// </summary>
	[DataMember(Name = "arp_resp")]
	public string? ArpResponse { get; set; }

	/// <summary>
	/// ARP source
	/// </summary>
	[DataMember(Name = "arp_src")]
	public string? ArpSource { get; set; }

	/// <summary>
	/// Attr
	/// </summary>
	[DataMember(Name = "attr")]
	public string? Attr { get; set; }

	/// <summary>
	/// The duration of the authentication negotiation.
	/// No units are documented by Meraki.
	/// </summary>
	[DataMember(Name = "auth_neg_dur")]
	public string? AuthenticationNegotiationDurationSeconds { get; set; }

	/// <summary>
	/// Band
	/// </summary>
	[DataMember(Name = "band")]
	public string? Band { get; set; }

	/// <summary>
	/// BSSID
	/// </summary>
	[DataMember(Name = "bssid")]
	public string? Bssid { get; set; }

	/// <summary>
	/// Channel
	/// </summary>
	[DataMember(Name = "channel")]
	public string? Channel { get; set; }

	/// <summary>
	/// Client IP
	/// </summary>
	[DataMember(Name = "client_ip")]
	public string? ClientIp { get; set; }

	/// <summary>
	/// Client mac
	/// </summary>
	[DataMember(Name = "client_mac")]
	public string? ClientMac { get; set; }

	/// <summary>
	/// Client mac
	/// </summary>
	[DataMember(Name = "device")]
	public string? Device { get; set; }

	/// <summary>
	/// The DHCP ip address
	/// </summary>
	[DataMember(Name = "dhcp_ip")]
	public string? DhcpIp { get; set; }

	/// <summary>
	/// The DHCP lease completed
	/// </summary>
	[DataMember(Name = "dhcp_lease_completed")]
	public string? DhcpLeaseCompleted { get; set; }

	/// <summary>
	/// The DHCP response time
	/// </summary>
	[DataMember(Name = "dhcp_resp")]
	public string? DhcpResponse { get; set; }

	/// <summary>
	/// The DHCP server
	/// </summary>
	[DataMember(Name = "dhcp_server")]
	public string? DhcpServer { get; set; }

	/// <summary>
	/// The DHCP server mac
	/// </summary>
	[DataMember(Name = "dhcp_server_mac")]
	public string? DhcpServerMac { get; set; }

	/// <summary>
	/// DOS Count
	/// </summary>
	[DataMember(Name = "dos_count")]
	public string? DosCount { get; set; }

	/// <summary>
	/// DST
	/// </summary>
	[DataMember(Name = "dst")]
	public string? Dst { get; set; }

	/// <summary>
	/// The duration
	/// </summary>
	[DataMember(Name = "duration")]
	public string? Duration { get; set; }

	/// <summary>
	/// The full conn
	/// </summary>
	[DataMember(Name = "full_conn")]
	public string? FullConn { get; set; }

	/// <summary>
	/// The group
	/// </summary>
	[DataMember(Name = "group")]
	public string? Group { get; set; }

	/// <summary>
	/// The HTTP response time
	/// </summary>
	[DataMember(Name = "http_resp")]
	public string? HttpResponse { get; set; }

	/// <summary>
	/// Identity
	/// </summary>
	[DataMember(Name = "identity")]
	public string? Identity { get; set; }

	/// <summary>
	/// The instigator
	/// </summary>
	[DataMember(Name = "instigator")]
	public string? Instigator { get; set; }

	/// <summary>
	/// Inter arrival
	/// </summary>
	[DataMember(Name = "inter_arrival")]
	public string? InterArrival { get; set; }

	/// <summary>
	/// The IP response time
	/// </summary>
	[DataMember(Name = "ip_resp")]
	public string? IpResponse { get; set; }

	/// <summary>
	/// The IP source address
	/// </summary>
	[DataMember(Name = "ip_src")]
	public string? IpSource { get; set; }

	/// <summary>
	/// Whether this is 802.11x
	/// </summary>
	[DataMember(Name = "is_8021x")]
	public string? Is8021x { get; set; }

	/// <summary>
	/// Last auth ago
	/// </summary>
	[DataMember(Name = "last_auth_ago")]
	public string? LastAuthAgo { get; set; }

	/// <summary>
	/// Last known client iP
	/// </summary>
	[DataMember(Name = "last_known_client_ip")]
	public string? LastKnownClientIp { get; set; }

	/// <summary>
	/// Packet
	/// </summary>
	[DataMember(Name = "packet")]
	public string? Packet { get; set; }

	/// <summary>
	/// Radio
	/// </summary>
	[DataMember(Name = "radio")]
	public string? Radio { get; set; }

	/// <summary>
	/// Reason
	/// </summary>
	[DataMember(Name = "reason")]
	public string? Reason { get; set; }

	/// <summary>
	/// RSSI
	/// </summary>
	[DataMember(Name = "rssi")]
	public string? Rssi { get; set; }

	/// <summary>
	/// The round trip time
	/// </summary>
	[DataMember(Name = "rtt")]
	public string? RoundTripTime { get; set; }

	/// <summary>
	/// The state
	/// </summary>
	[DataMember(Name = "state")]
	public string? State { get; set; }

	/// <summary>
	/// VAP
	/// </summary>
	[DataMember(Name = "vap")]
	public string? Vap { get; set; }
}
