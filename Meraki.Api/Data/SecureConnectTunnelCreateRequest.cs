namespace Meraki.Api.Data;

/// <summary>
/// SecureConnectTunnelCreateRequest
/// </summary>
[DataContract]
public class SecureConnectTunnelCreateRequest
{
	/// <summary>
	/// Site Origin ID to associate with the tunnel
	/// </summary>
	[DataMember(Name = "siteOriginId")]
	public int? SiteOriginId { get; set; }

	/// <summary>
	/// The type of device where the tunnel originates. The default value is other.
	/// </summary>
	[DataMember(Name = "deviceType")]
	public string? DeviceType { get; set; }

	/// <summary>
	/// The name of the tunnel.
	/// </summary>
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// The type of service to associate with the tunnel. The default value is SIG. enum = ["SIG", "Private Access"]
	/// </summary>
	[DataMember(Name = "serviceType")]
	public SecureConnectTunnelServiceType? ServiceType { get; set; }

	/// <summary>
	/// Enter IPv4 ranges and CIDR addresses.
	/// If serviceType is SIG, add all public and private address ranges used internally
	/// by your organization.Overrides Umbrella's default behavior,
	/// which allows traffic that is destined for RFC-1918 addresses to return through the tunnel.
	/// If serviceType is Private Access, this field is required.
	/// The 0.0.0.0/0 address range is not allowed.
	/// </summary>
	[DataMember(Name = "networkCIDRs")]
	public List<string>? NetworkCIDRs { get; set; }

	/// <summary>
	/// Authentication
	/// </summary>
	[DataMember(Name = "authentication")]
	public SecureConnectTunnelCreateRequestAuthentication? Authentication { get; set; }

	/// <summary>
	/// Transport
	/// </summary>
	[DataMember(Name = "transport")]
	public SecureConnectTunnelTransport? Transport { get; set; } = new();
}
