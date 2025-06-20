namespace Meraki.Api.Data;

/// <summary>
/// SecureConnectTunnel
/// </summary>
[DataContract]
public class SecureConnectTunnel
{
	/// <summary>
	/// The tunnel resource ID. Use this ID as a reference for subsequent requests.
	/// </summary>
	[ApiKey]
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public int? Id { get; set; }

	/// <summary>
	/// Site Origin ID to associate with the tunnel
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "siteOriginId")]
	public int? SiteOriginId { get; set; }

	/// <summary>
	/// The date and n time (UTC time with milliseconds) when the tunnel was created.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "createdAt")]
	public DateTime CreatedAt { get; set; }

	/// <summary>
	/// The date and time (timestamp) that Umbrella updated the tag on the roaming computer. The timestamp is an ISO 8601 formatted string. For example: 2023-04-12T23:20:50.52Z.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "modifiedAt")]
	public DateTime ModifiedAt { get; set; }

	/// <summary>
	/// The display name of the tunnel. The tunnel name is required, cannot exceed 50 characters in length,and cannot have any special characters other than spaces and hyphens.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// The type of service to associate with the tunnel. The default value is SIG. enum = ["SIG", "Private Access"]
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "serviceType")]
	public SecureConnectTunnelServiceType ServiceType { get; set; }

	/// <summary>
	/// Resource URI
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "uri")]
	public string Uri { get; set; } = string.Empty;

	/// <summary>
	/// Enter IPv4 ranges and CIDR addresses.
	/// If serviceType is SIG, add all public and private address ranges used internally
	/// by your organization.Overrides Umbrella's default behavior,
	/// which allows traffic that is destined for RFC-1918 addresses to return through the tunnel.
	/// If serviceType is Private Access, this field is required.
	/// The 0.0.0.0/0 address range is not allowed.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "networkCIDRs")]
	public List<string>? NetworkCIDRs { get; set; }

	/// <summary>
	/// The tunnel client's configuration metadata.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "client")]
	public SecureConnectTunnelClient? Client { get; set; }

	/// <summary>
	/// The metadata for the tunnel object that relates to service internals.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "meta")]
	public SecureConnectTunnelMeta Meta { get; set; } = new();

	/// <summary>
	/// Transport
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "transport")]
	public SecureConnectTunnelTransport Transport { get; set; } = new();
}
